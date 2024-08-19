using IMGUI_Render;


//static Dictionary<string, string> Rotor_1 =
//            new Dictionary<string, string>
//            {

//            };

public class Program
{

    // Encryption Dictionaries

    static Dictionary<string, string> Rotor_1 =
                new Dictionary<string, string>
                {
                    {"A","G"},
                    {"B","K"},
                    {"C","2"},
                    {"D","6"},
                    {"E","?"},
                    {"F","1"},
                    {"G","A"},
                    {"H","Z"},
                    {"I","!"},
                    {"J","0"},
                    {"K","B"},
                    {"L","O"},
                    {"M","Q"},
                    {"N","."},
                    {"O","L"},
                    {"P","V"},
                    {"Q","M"},
                    {"R","4"},
                    {"S","3"},
                    {"T",","},
                    {"U","Y"},
                    {"V","P"},
                    {"W","9"},
                    {"X","7"},
                    {"Y","U"},
                    {"Z","H"},
                    {"0","J"},
                    {"1","F"},
                    {"2","C"},
                    {"3","S"},
                    {"4","R"},
                    {"5","8"},
                    {"6","D"},
                    {"7","X"},
                    {"8","5"},
                    {"9","W"},
                    {".","N"},
                    {",","T"},
                    {"?","E"},
                    {"!","I"}
                };

    static Dictionary<string, string> Rotor_2 =
                new Dictionary<string, string>
                {
                    {"A","J"},
                    {"B","M"},
                    {"C","Z"},
                    {"D","P"},
                    {"E","!"},
                    {"F","L"},
                    {"G","?"},
                    {"H","8"},
                    {"I","3"},
                    {"J","A"},
                    {"K","."},
                    {"L","F"},
                    {"M","B"},
                    {"N","6"},
                    {"O","T"},
                    {"P","D"},
                    {"Q","4"},
                    {"R","U"},
                    {"S","Y"},
                    {"T","O"},
                    {"U","R"},
                    {"V","7"},
                    {"W","X"},
                    {"X","W"},
                    {"Y","S"},
                    {"Z","C"},
                    {"0","2"},
                    {"1","9"},
                    {"2","0"},
                    {"3","I"},
                    {"4","Q"},
                    {"5",","},
                    {"6","N"},
                    {"7","V"},
                    {"8","H"},
                    {"9","1"},
                    {".","K"},
                    {",","5"},
                    {"?","G"},
                    {"!","E"}
                };

    static Dictionary<string, string> Rotor_3 =
                new Dictionary<string, string>
                {
                    {"A","9"},
                    {"B","F"},
                    {"C","I"},
                    {"D","O"},
                    {"E","U"},
                    {"F","B"},
                    {"G","S"},
                    {"H","."},
                    {"I","C"},
                    {"J","Q"},
                    {"K","?"},
                    {"L","4"},
                    {"M","Y"},
                    {"N","1"},
                    {"O","D"},
                    {"P","Z"},
                    {"Q","J"},
                    {"R","V"},
                    {"S","G"},
                    {"T","!"},
                    {"U","E"},
                    {"V","R"},
                    {"W","3"},
                    {"X","7"},
                    {"Y","M"},
                    {"Z","P"},
                    {"0","2"},
                    {"1","N"},
                    {"2","0"},
                    {"3","W"},
                    {"4","L"},
                    {"5","8"},
                    {"6",","},
                    {"7","X"},
                    {"8","5"},
                    {"9","A"},
                    {".","H"},
                    {",","6"},
                    {"?","K"},
                    {"!","T"}
                };

    static Dictionary<string, string> Rotor_4 =
                new Dictionary<string, string>
                {
                    {"A","G"},
                    {"B","F"},
                    {"C","0"},
                    {"D","O"},
                    {"E","L"},
                    {"F","B"},
                    {"G","A"},
                    {"H","K"},
                    {"I","Q"},
                    {"J","1"},
                    {"K","H"},
                    {"L","E"},
                    {"M","?"},
                    {"N","8"},
                    {"O","D"},
                    {"P","W"},
                    {"Q","I"},
                    {"R","7"},
                    {"S","V"},
                    {"T","Z"},
                    {"U","Y"},
                    {"V","S"},
                    {"W","P"},
                    {"X","4"},
                    {"Y","U"},
                    {"Z","T"},
                    {"0","C"},
                    {"1","J"},
                    {"2","!"},
                    {"3","."},
                    {"4","X"},
                    {"5",","},
                    {"6","9"},
                    {"7","R"},
                    {"8","N"},
                    {"9","6"},
                    {".","3"},
                    {",","5"},
                    {"?","M"},
                    {"!","2"}
                };

    static Dictionary<string, string> Rotor_5 =
                new Dictionary<string, string>
                {
                    {"A","F"},
                    {"B","I"},
                    {"C","O"},
                    {"D","P"},
                    {"E","1"},
                    {"F","A"},
                    {"G","Q"},
                    {"H","."},
                    {"I","B"},
                    {"J","V"},
                    {"K","?"},
                    {"L",","},
                    {"M","T"},
                    {"N","7"},
                    {"O","C"},
                    {"P","D"},
                    {"Q","G"},
                    {"R","!"},
                    {"S","4"},
                    {"T","M"},
                    {"U","Z"},
                    {"V","J"},
                    {"W","2"},
                    {"X","6"},
                    {"Y","9"},
                    {"Z","U"},
                    {"0","8"},
                    {"1","E"},
                    {"2","W"},
                    {"3","5"},
                    {"4","S"},
                    {"5","3"},
                    {"6","X"},
                    {"7","N"},
                    {"8","0"},
                    {"9","Y"},
                    {".","H"},
                    {",","L"},
                    {"?","K"},
                    {"!","R"}
                };

    static Dictionary<string, string> Rotor_6 =
                new Dictionary<string, string>
                {
                    {"A","T"},
                    {"B","Q"},
                    {"C","!"},
                    {"D","2"},
                    {"E","4"},
                    {"F","H"},
                    {"G",","},
                    {"H","F"},
                    {"I","6"},
                    {"J","9"},
                    {"K","Z"},
                    {"L","?"},
                    {"M","1"},
                    {"N","8"},
                    {"O","3"},
                    {"P","U"},
                    {"Q","B"},
                    {"R","W"},
                    {"S","Y"},
                    {"T","A"},
                    {"U","P"},
                    {"V","0"},
                    {"W","R"},
                    {"X","."},
                    {"Y","S"},
                    {"Z","K"},
                    {"0","V"},
                    {"1","M"},
                    {"2","D"},
                    {"3","O"},
                    {"4","E"},
                    {"5","7"},
                    {"6","I"},
                    {"7","5"},
                    {"8","N"},
                    {"9","J"},
                    {".","X"},
                    {",","G"},
                    {"?","L"},
                    {"!","C"}
                };

    static Dictionary<string, string> Rotor_7 =
                new Dictionary<string, string>
                {
                    {"A","H"},
                    {"B","!"},
                    {"C","3"},
                    {"D","6"},
                    {"E","T"},
                    {"F","S"},
                    {"G","K"},
                    {"H","A"},
                    {"I","Y"},
                    {"J","7"},
                    {"K","G"},
                    {"L","9"},
                    {"M","2"},
                    {"N","0"},
                    {"O","5"},
                    {"P","W"},
                    {"Q","U"},
                    {"R","4"},
                    {"S","F"},
                    {"T","E"},
                    {"U","Q"},
                    {"V",","},
                    {"W","P"},
                    {"X","?"},
                    {"Y","I"},
                    {"Z","."},
                    {"0","N"},
                    {"1","8"},
                    {"2","M"},
                    {"3","C"},
                    {"4","R"},
                    {"5","O"},
                    {"6","D"},
                    {"7","J"},
                    {"8","1"},
                    {"9","L"},
                    {".","Z"},
                    {",","V"},
                    {"?","X"},
                    {"!","B"}
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
                new Dictionary<int, Dictionary<string, string>>
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
      
    }

    int Converter(int imput)
    {
      
        return 0;
    }

    int ConvertVal(int input, int Selected, int offset)
    {
        int cleanoffset = input;

        cleanoffset = input + offset;

        if (cleanoffset > 40)
        {
            cleanoffset -= 40;
        }

        int output = Main_Dictionary[Selected][cleanoffset] - offset;

        if (output < 1)
        {
            output += 40;
        }

        return output;
    }

}