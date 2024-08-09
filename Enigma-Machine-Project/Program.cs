using IMGUI_Render;

public class Program
{

    // Encryption Dictionaries

    static Dictionary<int, int> Rotor_1 =
                new Dictionary<int, int>
                {
                { 1, 10 },
                { 2, 15 },
                { 3, 7 },
                { 4, 18 },
                { 5, 23 },
                { 6, 20 },
                { 7, 3 },
                { 8, 13 },
                { 9, 21 },
                { 10, 1 },
                { 11, 12 },
                { 12, 11 },
                { 13, 8 },
                { 14, 19 },
                { 15, 2 },
                { 16, 22 },
                { 17, 26 },
                { 18, 4 },
                { 19, 14 },
                { 20, 6 },
                { 21, 9 },
                { 22, 16 },
                { 23, 5 },
                { 24, 25 },
                { 25, 24 },
                { 26, 17 }
                };

    static Dictionary<int, int> Rotor_2 =
                new Dictionary<int, int>
                {
                { 1, 14 },
                { 2, 5 },
                { 3, 19 },
                { 4, 10 },
                { 5, 2 },
                { 6, 18 },
                { 7, 15 },
                { 8, 12 },
                { 9, 25 },
                { 10, 4 },
                { 11, 16 },
                { 12, 8 },
                { 13, 21 },
                { 14, 1 },
                { 15, 7 },
                { 16, 11 },
                { 17, 24 },
                { 18, 6 },
                { 19, 3 },
                { 20, 26 },
                { 21, 13 },
                { 22, 23 },
                { 23, 22 },
                { 24, 17 },
                { 25, 9 },
                { 26, 20}
                };

    static Dictionary<int, int> Rotor_3 =
                new Dictionary<int, int>
                {
                { 1, 20 },
                { 2, 25 },
                { 3, 19 },
                { 4, 10 },
                { 5, 24 },
                { 6, 14 },
                { 7, 18 },
                { 8, 12 },
                { 9, 21 },
                { 10, 4 },
                { 11, 22 },
                { 12, 8 },
                { 13, 16 },
                { 14, 6 },
                { 15, 26 },
                { 16, 13 },
                { 17, 23 },
                { 18, 7 },
                { 19, 3 },
                { 20, 1 },
                { 21, 9 },
                { 22, 11 },
                { 23, 17 },
                { 24, 5 },
                { 25, 2 },
                { 26, 15 }
                };

    static Dictionary<int, int> Rotor_4 =
                new Dictionary<int, int>
                {
                { 1, 5 },
                { 2, 12 },
                { 3, 25 },
                { 4, 18 },
                { 5, 1 },
                { 6, 15 },
                { 7, 11 },
                { 8, 24 },
                { 9, 21 },
                { 10, 19 },
                { 11, 7 },
                { 12, 2 },
                { 13, 23 },
                { 14, 20 },
                { 15, 6 },
                { 16, 26 },
                { 17, 22 },
                { 18, 4 },
                { 19, 10 },
                { 20, 14 },
                { 21, 9 },
                { 22, 17 },
                { 23, 13 },
                { 24, 8 },
                { 25, 3 },
                { 26, 16 }
                };

    static Dictionary<int, int> Rotor_5 =
                new Dictionary<int, int>
                {
                { 1, 18 },
                { 2, 10 },
                { 3, 15 },
                { 4, 17 },
                { 5, 25 },
                { 6, 20 },
                { 7, 14 },
                { 8, 22 },
                { 9, 24 },
                { 10, 2 },
                { 11, 19 },
                { 12, 26 },
                { 13, 23 },
                { 14, 7 },
                { 15, 3 },
                { 16, 21 },
                { 17, 4 },
                { 18, 1 },
                { 19, 11 },
                { 20, 6 },
                { 21, 16 },
                { 22, 8 },
                { 23, 13 },
                { 24, 9 },
                { 25, 5 },
                { 26, 12 }
                };

    static Dictionary<int, int> Reflector =
                new Dictionary<int, int>
                {
                { 1, 9 },
                { 2, 18 },
                { 3, 20 },
                { 4, 17 },
                { 5, 25 },
                { 6, 15 },
                { 7, 16 },
                { 8, 22 },
                { 9, 1 },
                { 10, 19 },
                { 11, 12 },
                { 12, 11 },
                { 13, 26 },
                { 14, 23 },
                { 15, 6 },
                { 16, 7 },
                { 17, 4 },
                { 18, 2 },
                { 19, 10 },
                { 20, 3 },
                { 21, 24 },
                { 22, 8 },
                { 23, 14 },
                { 24, 21 },
                { 25, 5 },
                { 26, 13 }
                };

    static Dictionary<int, Dictionary<int, int>> Main_Dictionary =
                new Dictionary<int, Dictionary<int, int>>
                {
                {0, Rotor_1},
                {1, Rotor_2},
                {2, Rotor_3},
                {3, Rotor_4},
                {4, Rotor_5},
                {5, Reflector}
                };


    private static void Main(string[] args)
    {
        // start imgui in a seperate thread
        Renderer renderer = new Renderer();
        Thread renderThread = new Thread(renderer.Start().Wait);
        renderThread.Start();
    }

    public string Convert(string input)
    {
        List<string> converted_Text = [];
        string result = input;



        // For Loop To Convert
        for (int i = 0; i < input.Length; i++)
        {
            Increment();

            if (char.IsLetter(input[i]))
            {
                char letter = char.ToLower(input[i]);
                int numtext = Converter(letter - 'a' + 1);
                char Cletter = (char)(numtext + 'a' - 1);
                converted_Text.Add(Cletter.ToString());
            }
            else
            {
                converted_Text.Add(input[i].ToString());
            }
        }

        return string.Join("", converted_Text);
    }

    void Increment()
    {
        Renderer.Rotation_C++;

        if (Renderer.Rotation_C > 26)
        {
            Renderer.Rotation_C = 1;
            Renderer.Rotation_B++;
        }

        if (Renderer.Rotation_B > 26)
        {
            Renderer.Rotation_B = 1;
            Renderer.Rotation_A++;
        }

        if (Renderer.Rotation_A > 26)
        {
            Renderer.Rotation_A = 1;
        }
    }

    int Converter(int imput)
    {
        int C1 = ConvertVal(imput, Renderer.selectedIndices[2], Renderer.Rotation_C);
        int C2 = ConvertVal(C1, Renderer.selectedIndices[1], Renderer.Rotation_B);
        int C3 = ConvertVal(C2, Renderer.selectedIndices[0], Renderer.Rotation_A);
        int C4 = ConvertVal(C3, 5, 0);
        int C5 = ConvertVal(C4, Renderer.selectedIndices[0], Renderer.Rotation_A);
        int C6 = ConvertVal(C5, Renderer.selectedIndices[1], Renderer.Rotation_B);
        int Converted_Value = ConvertVal(C6, Renderer.selectedIndices[2], Renderer.Rotation_C);

        return Converted_Value;
    }

    int ConvertVal(int input, int Selected, int offset)
    {
        int cleanoffset = input;

        cleanoffset = input + offset;

        if (cleanoffset > 26)
        {
            cleanoffset -= 26;
        }

        int output = Main_Dictionary[Selected][cleanoffset] - offset;

        if (output < 1)
        {
            output += 26;
        }

        return output;
    }

}