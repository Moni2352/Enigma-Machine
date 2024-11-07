using IMGUI_Renderer;
using Vortice.Mathematics;
using Rotors;

// start imgui in a seperate thread
Console.WriteLine("Starting ImGui..");
Renderer renderer = new Renderer();
Thread renderThread = new Thread(renderer.Start().Wait);
renderThread.Start();



namespace program
{
    public class Main
    {
        //Rotors.Rotordata Rotordata = new Rotors.Rotordata();

        Dictionary<int, Dictionary<int, int>> Changers = new Dictionary<int, Dictionary<int, int>>()
        {

            { 0, Rotordata.Rotor1 },
            { 1, Rotordata.Rotor2 },
            { 2, Rotordata.Rotor3 },
            { 3, Rotordata.Rotor4 },
            { 4, Rotordata.Rotor5 },
            { 5, Rotordata.Rotor6 },
            { 6, Rotordata.Rotor7 },
            { 7, Rotordata.Rotor8 },
            { 8, Rotordata.UKWB },
            { 9, Rotordata.UKWC },


        };

        public int[][] RotorTurn = { [18, 18], [6, 6], [23, 23], [11, 11], [1, 1], [1, 14], [1, 14], [1, 14] };

        public string Converter(string input)
        {
            string output = null;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsAsciiLetter(input[i]))
                {
                Increment();

                int ConvertedLetter = LetterConvert(char.ToUpper(input[i]) - 64);

                output = output + char.ToLower(Convert.ToChar(ConvertedLetter + 64));
                }
                else
                {
                    output = output + input[i];
                }
            }

            return output;
        }


        public void Increment()
        {
            Renderer.RotorRotations[2]++;

            if (Renderer.RotorRotations[2] == RotorTurn[Renderer.selectedIndices[2]][0] || Renderer.RotorRotations[2] == RotorTurn[Renderer.selectedIndices[2]][1])
            {
                Renderer.RotorRotations[1]++;
                if (Renderer.RotorRotations[1] == RotorTurn[Renderer.selectedIndices[1]][0] || Renderer.RotorRotations[1] == RotorTurn[Renderer.selectedIndices[1]][1])
                {
                    Renderer.RotorRotations[0]++;
                }
            }

            if (Renderer.RotorRotations[2] == 27)
            {
                Renderer.RotorRotations[2] = 0;
            }

            if (Renderer.RotorRotations[1] == 27)
            {
                Renderer.RotorRotations[1] = 0;
            }

            if (Renderer.RotorRotations[0] == 27)
            {
                Renderer.RotorRotations[0] = 0;
            }
        }


        public int LetterConvert(int baseLetter)
        {

            // Pass Through PlugBoard
            int plugALetter = baseLetter;


            // Pass Through Rotors

            int rotor1Letter = RotorConvert(plugALetter, Renderer.selectedIndices[2], Renderer.RotorRotations[2]);
            int rotor2Letter = RotorConvert(rotor1Letter, Renderer.selectedIndices[1], Renderer.RotorRotations[1]);
            int rotor3Letter = RotorConvert(rotor2Letter, Renderer.selectedIndices[0], Renderer.RotorRotations[0]);

            int reflectorLetter = RotorConvert(rotor3Letter, Renderer.CurrentReflector + 8, 0);

            int rotor4Letter = RotorConvert(reflectorLetter, Renderer.selectedIndices[0], Renderer.RotorRotations[0]);
            int rotor5Letter = RotorConvert(rotor4Letter, Renderer.selectedIndices[1], Renderer.RotorRotations[1]);
            int rotor6Letter = RotorConvert(rotor5Letter, Renderer.selectedIndices[2], Renderer.RotorRotations[2]);


            // Pass Through PlugBoard
            int plugBLetter = rotor6Letter;


            return plugBLetter;
        }

        
        int RotorConvert(int input, int rotor, int offset)
        {


            int cleanoffset = input;

            cleanoffset = input + offset;

            if (cleanoffset > 26)
            {
                cleanoffset -= 26;
            }

            int output = Changers[rotor][cleanoffset] - offset;

            if (output < 1)
            {
                output += 26;
            }

            return output;
        }



    }



}