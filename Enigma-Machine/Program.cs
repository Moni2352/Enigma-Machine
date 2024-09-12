using IMGUI_Renderer;

// start imgui in a seperate thread
Console.WriteLine("Starting ImGui..");
Renderer renderer = new Renderer();
Thread renderThread = new Thread(renderer.Start().Wait);
renderThread.Start();

namespace program
{
    public class Main
    {

        int[] RotorRotations = {0, 0, 0};

        string[] Rotor1Turn = { "R" };
        string[] Rotor2Turn = { "F" };
        string[] Rotor3Turn = { "W" };
        string[] Rotor4Turn = { "K" };
        string[] Rotor5Turn = { "A" };
        string[] Rotor6Turn = { "A", "N" };
        string[] Rotor7Turn = { "A", "N" };
        string[] Rotor8Turn = { "A", "N" };



        public static string Converter(string input)
        {
            string output = null;

            for (int i = 0; i < input.Length; i++)
            {
                // Increment
                // Code
                // Add
            }

            return output;
        }

        void Increment()
        {
            RotorRotations[2]++;
            if (RotorRotations[2] == 27)
            {
                RotorRotations[2] = 0;
            }

            if (RotorRotations[1] == 27)
            {
                RotorRotations[1] = 0;
            }

            if (RotorRotations[0] == 27)
            {
                RotorRotations[0] = 0;
            }
        }

    }



}