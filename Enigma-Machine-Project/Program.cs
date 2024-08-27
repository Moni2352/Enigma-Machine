using System.Collections;
using System.Runtime.InteropServices;
using Enigma_Machine_Project;
using IMGUI_Render;


// static Dictionary<string, string> Rotor_1 =
//            new Dictionary<string, string>
//            {

//            };

public class Program
{


// Actual Coding Now!?


    // Start Rendering Thread
    private static void Main(string[] args)
    {
        // start imgui in a seperate thread
        Renderer renderer = new Renderer();
        Thread renderThread = new Thread(renderer.Start().Wait);
        renderThread.Start();


    }



    // Conversion Function
    public string Convert(string input)
    {
        string output = "";
        string CleanText = input.ToUpper();

        for (int i = 0; i < input.Length; i++)
        {
            // Increment Rotors
            Increment();

            output += ConvertChar(CleanText[i]);
        }

        return output;
    }

    // Function To Convert A single Letter
    string ConvertChar(char input)
    {

        if (!Encoder_Dictionaries.Translator.ContainsKey(input.ToString()))
        {
            return input.ToString();
        }


        char NewInput = input;

        // Into Rotors
        for (int i = 0; i < Renderer.NumOfRotors; i++)
        {
           NewInput = RotorConvert(NewInput, i);
        }

        // Reflector
        NewInput = RotorConvert(NewInput, 10);

        // Out Of Rotors

        for (int i = Renderer.NumOfRotors - 1; i >= 0; i--)
        {
            NewInput = RotorConvert(NewInput, i);
        }


        return NewInput.ToString();
    }

    // Rotor Convert Function

    char RotorConvert(char input, int RotorUsed)
    {

        int NumChar = Encoder_Dictionaries.Translator[input.ToString()];
        int RotorRotation = 0;

            if (RotorUsed != 10)
            {
                RotorRotation = Renderer.RotorRotations[RotorUsed];
            } 

            int CleanOffset = NumChar + RotorRotation;

            if (CleanOffset > 40)
            {
                CleanOffset -= 40;
            }



            string OffsetChar = Encoder_Dictionaries.Translator.FirstOrDefault(x => x.Value == CleanOffset).Key;

            string PostConvert = Encoder_Dictionaries.Main_Dictionary[Renderer.selectedIndices[RotorUsed]][OffsetChar];

            int ConvertedInt = Encoder_Dictionaries.Translator[PostConvert];
            ConvertedInt -= RotorRotation;

            if (ConvertedInt < 1)
            {
                ConvertedInt += 40;
            }

            
            return Encoder_Dictionaries.Translator.FirstOrDefault(x => x.Value == ConvertedInt).Key[0];
    }

    // Increment Funtion
    void Increment()
    {

        Renderer.RotorRotations[0] ++;
        
        for (int i = 1; i <= 9; i++)
        {
            if (Renderer.RotorRotations[i-1] > 40)
            {
                Renderer.RotorRotations[i-1] = 0;
                Renderer.RotorRotations[i] ++;
            }

            if (Renderer.RotorRotations[9] > 40)
            {
                Renderer.RotorRotations[9] = 0;
            }


        }




    }

    // int ConvertVal(int input, int Selected, int offset)
    // {
    //     int cleanoffset = input;

    //     cleanoffset = input + offset;

    //     if (cleanoffset > 40)
    //     {
    //         cleanoffset -= 40;
    //     }

    //     int output = Main_Dictionary[Selected][cleanoffset] - offset;

    //     if (output < 1)
    //     {
    //         output += 40;
    //     }

    //     return output;
    // }

}