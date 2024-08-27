using System.Collections;
using System.Runtime.InteropServices;
using IMGUI_Render;


// static Dictionary<string, string> Rotor_1 =
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

    static Dictionary<string, string> Rotor_8 =
                new Dictionary<string, string>
                {
                    {"A","T"},
                    {"B","K"},
                    {"C","P"},
                    {"D",","},
                    {"E","3"},
                    {"F","S"},
                    {"G","6"},
                    {"H","."},
                    {"I","Z"},
                    {"J","W"},
                    {"K","B"},
                    {"L","!"},
                    {"M","8"},
                    {"N","Q"},
                    {"O","5"},
                    {"P","C"},
                    {"Q","N"},
                    {"R","U"},
                    {"S","F"},
                    {"T","A"},
                    {"U","R"},
                    {"V","X"},
                    {"W","J"},
                    {"X","V"},
                    {"Y","?"},
                    {"Z","I"},
                    {"0","9"},
                    {"1","4"},
                    {"2","7"},
                    {"3","E"},
                    {"4","1"},
                    {"5","O"},
                    {"6","G"},
                    {"7","2"},
                    {"8","M"},
                    {"9","0"},
                    {".","H"},
                    {",","D"},
                    {"?","Y"},
                    {"!","L"}
                };

    static Dictionary<string, string> Rotor_9 =
                new Dictionary<string, string>
                {
                    {"A","G"},
                    {"B","H"},
                    {"C","3"},
                    {"D","."},
                    {"E","O"},
                    {"F","?"},
                    {"G","A"},
                    {"H","B"},
                    {"I","W"},
                    {"J","Z"},
                    {"K","0"},
                    {"L","!"},
                    {"M",","},
                    {"N","T"},
                    {"O","E"},
                    {"P","S"},
                    {"Q","7"},
                    {"R","V"},
                    {"S","P"},
                    {"T","N"},
                    {"U","4"},
                    {"V","R"},
                    {"W","I"},
                    {"X","9"},
                    {"Y","6"},
                    {"Z","J"},
                    {"0","K"},
                    {"1","5"},
                    {"2","8"},
                    {"3","C"},
                    {"4","U"},
                    {"5","1"},
                    {"6","Y"},
                    {"7","Q"},
                    {"8","2"},
                    {"9","X"},
                    {".","D"},
                    {",","M"},
                    {"?","F"},
                    {"!","L"}
                };

    static Dictionary<string, string> Rotor_10 =
                new Dictionary<string, string>
                {
                    {"A","F"},
                    {"B","3"},
                    {"C","1"},
                    {"D","!"},
                    {"E","T"},
                    {"F","A"},
                    {"G","V"},
                    {"H","5"},
                    {"I","S"},
                    {"J","O"},
                    {"K","X"},
                    {"L","9"},
                    {"M","7"},
                    {"N","R"},
                    {"O","J"},
                    {"P",","},
                    {"Q","."},
                    {"R","N"},
                    {"S","I"},
                    {"T","E"},
                    {"U","Z"},
                    {"V","G"},
                    {"W","2"},
                    {"X","K"},
                    {"Y","?"},
                    {"Z","U"},
                    {"0","8"},
                    {"1","C"},
                    {"2","W"},
                    {"3","B"},
                    {"4","6"},
                    {"5","H"},
                    {"6","4"},
                    {"7","M"},
                    {"8","0"},
                    {"9","L"},
                    {".","Q"},
                    {",","P"},
                    {"?","Y"},
                    {"!","D"}
                };

    static Dictionary<string, string> Rotor_11 =
                new Dictionary<string, string>
                {
                    {"A","3"},
                    {"B","T"},
                    {"C","H"},
                    {"D","I"},
                    {"E","!"},
                    {"F",","},
                    {"G","4"},
                    {"H","C"},
                    {"I","D"},
                    {"J","Y"},
                    {"K","7"},
                    {"L","?"},
                    {"M","P"},
                    {"N","1"},
                    {"O","Z"},
                    {"P","M"},
                    {"Q","8"},
                    {"R","9"},
                    {"S","2"},
                    {"T","B"},
                    {"U","6"},
                    {"V","5"},
                    {"W","0"},
                    {"X","."},
                    {"Y","J"},
                    {"Z","O"},
                    {"0","W"},
                    {"1","N"},
                    {"2","S"},
                    {"3","A"},
                    {"4","G"},
                    {"5","V"},
                    {"6","U"},
                    {"7","K"},
                    {"8","Q"},
                    {"9","R"},
                    {".","X"},
                    {",","F"},
                    {"?","L"},
                    {"!","E"}
                };

    static Dictionary<string, string> Rotor_12 =
                new Dictionary<string, string>
                {
                    {"A","."},
                    {"B","W"},
                    {"C","T"},
                    {"D","V"},
                    {"E","?"},
                    {"F","!"},
                    {"G","4"},
                    {"H","Y"},
                    {"I","X"},
                    {"J","0"},
                    {"K","S"},
                    {"L","8"},
                    {"M","3"},
                    {"N","R"},
                    {"O",","},
                    {"P","2"},
                    {"Q","9"},
                    {"R","N"},
                    {"S","K"},
                    {"T","C"},
                    {"U","6"},
                    {"V","D"},
                    {"W","B"},
                    {"X","I"},
                    {"Y","H"},
                    {"Z","1"},
                    {"0","J"},
                    {"1","Z"},
                    {"2","P"},
                    {"3","M"},
                    {"4","G"},
                    {"5","7"},
                    {"6","U"},
                    {"7","5"},
                    {"8","L"},
                    {"9","Q"},
                    {".","A"},
                    {",","O"},
                    {"?","E"},
                    {"!","F"}
                };

    static Dictionary<string, string> Rotor_13 =
                new Dictionary<string, string>
                {
                    {"A","T"},
                    {"B","V"},
                    {"C",","},
                    {"D","9"},
                    {"E","4"},
                    {"F","P"},
                    {"G","Z"},
                    {"H","3"},
                    {"I","L"},
                    {"J","O"},
                    {"K","7"},
                    {"L","I"},
                    {"M","U"},
                    {"N","R"},
                    {"O","J"},
                    {"P","F"},
                    {"Q","0"},
                    {"R","N"},
                    {"S","?"},
                    {"T","A"},
                    {"U","M"},
                    {"V","B"},
                    {"W","2"},
                    {"X","1"},
                    {"Y","5"},
                    {"Z","G"},
                    {"0","Q"},
                    {"1","X"},
                    {"2","W"},
                    {"3","H"},
                    {"4","E"},
                    {"5","Y"},
                    {"6","!"},
                    {"7","K"},
                    {"8","."},
                    {"9","D"},
                    {".","8"},
                    {",","C"},
                    {"?","S"},
                    {"!","6"}
                };

    static Dictionary<string, string> Rotor_14 =
                new Dictionary<string, string>
                {
                    {"A","T"},
                    {"B","K"},
                    {"C","0"},
                    {"D","Z"},
                    {"E","!"},
                    {"F","P"},
                    {"G","I"},
                    {"H","X"},
                    {"I","G"},
                    {"J",","},
                    {"K","B"},
                    {"L","."},
                    {"M","6"},
                    {"N","W"},
                    {"O","7"},
                    {"P","F"},
                    {"Q","V"},
                    {"R","9"},
                    {"S","2"},
                    {"T","A"},
                    {"U","5"},
                    {"V","Q"},
                    {"W","N"},
                    {"X","H"},
                    {"Y","3"},
                    {"Z","D"},
                    {"0","C"},
                    {"1","8"},
                    {"2","S"},
                    {"3","Y"},
                    {"4","?"},
                    {"5","U"},
                    {"6","M"},
                    {"7","O"},
                    {"8","1"},
                    {"9","R"},
                    {".","L"},
                    {",","J"},
                    {"?","4"},
                    {"!","E"}
                };

    static Dictionary<string, string> Rotor_15 =
                new Dictionary<string, string>
                {
                    {"A","!"},
                    {"B","5"},
                    {"C","Z"},
                    {"D","8"},
                    {"E","1"},
                    {"F","T"},
                    {"G","K"},
                    {"H","P"},
                    {"I","."},
                    {"J","M"},
                    {"K","G"},
                    {"L","3"},
                    {"M","J"},
                    {"N","X"},
                    {"O","R"},
                    {"P","H"},
                    {"Q","6"},
                    {"R","O"},
                    {"S","0"},
                    {"T","F"},
                    {"U","?"},
                    {"V","7"},
                    {"W","2"},
                    {"X","N"},
                    {"Y","9"},
                    {"Z","C"},
                    {"0","S"},
                    {"1","E"},
                    {"2","W"},
                    {"3","L"},
                    {"4",","},
                    {"5","B"},
                    {"6","Q"},
                    {"7","V"},
                    {"8","D"},
                    {"9","Y"},
                    {".","I"},
                    {",","4"},
                    {"?","U"},
                    {"!","A"}
                };

    static Dictionary<string, string> Rotor_16 =
                new Dictionary<string, string>
                {
                    {"A","5"},
                    {"B","2"},
                    {"C","W"},
                    {"D","Z"},
                    {"E","?"},
                    {"F","N"},
                    {"G","T"},
                    {"H","Q"},
                    {"I","9"},
                    {"J","Y"},
                    {"K","7"},
                    {"L","S"},
                    {"M","X"},
                    {"N","F"},
                    {"O","U"},
                    {"P","1"},
                    {"Q","H"},
                    {"R","!"},
                    {"S","L"},
                    {"T","G"},
                    {"U","O"},
                    {"V","."},
                    {"W","C"},
                    {"X","M"},
                    {"Y","J"},
                    {"Z","D"},
                    {"0","3"},
                    {"1","P"},
                    {"2","B"},
                    {"3","0"},
                    {"4",","},
                    {"5","A"},
                    {"6","8"},
                    {"7","K"},
                    {"8","6"},
                    {"9","I"},
                    {".","V"},
                    {",","4"},
                    {"?","E"},
                    {"!","R"}
                };

    static Dictionary<string, string> Rotor_17 =
                new Dictionary<string, string>
                {
                    {"A","5"},
                    {"B","T"},
                    {"C","K"},
                    {"D","H"},
                    {"E","?"},
                    {"F","1"},
                    {"G","P"},
                    {"H","D"},
                    {"I","8"},
                    {"J","Y"},
                    {"K","C"},
                    {"L","W"},
                    {"M","Z"},
                    {"N","3"},
                    {"O","R"},
                    {"P","G"},
                    {"Q","."},
                    {"R","O"},
                    {"S","6"},
                    {"T","B"},
                    {"U","!"},
                    {"V",","},
                    {"W","L"},
                    {"X","4"},
                    {"Y","J"},
                    {"Z","M"},
                    {"0","9"},
                    {"1","F"},
                    {"2","7"},
                    {"3","N"},
                    {"4","X"},
                    {"5","A"},
                    {"6","S"},
                    {"7","2"},
                    {"8","I"},
                    {"9","0"},
                    {".","Q"},
                    {",","V"},
                    {"?","E"},
                    {"!","U"}
                };

    static Dictionary<string, string> Rotor_18 =
                new Dictionary<string, string>
                {
                    {"A","Z"},
                    {"B","4"},
                    {"C","!"},
                    {"D","?"},
                    {"E","T"},
                    {"F","L"},
                    {"G","N"},
                    {"H","3"},
                    {"I","9"},
                    {"J","2"},
                    {"K","5"},
                    {"L","F"},
                    {"M","V"},
                    {"N","G"},
                    {"O","0"},
                    {"P",","},
                    {"Q","X"},
                    {"R","6"},
                    {"S","U"},
                    {"T","E"},
                    {"U","S"},
                    {"V","M"},
                    {"W","8"},
                    {"X","Q"},
                    {"Y","7"},
                    {"Z","A"},
                    {"0","O"},
                    {"1","."},
                    {"2","J"},
                    {"3","H"},
                    {"4","B"},
                    {"5","K"},
                    {"6","R"},
                    {"7","Y"},
                    {"8","W"},
                    {"9","I"},
                    {".","1"},
                    {",","P"},
                    {"?","D"},
                    {"!","C"}
                };

    static Dictionary<string, string> Rotor_19 =
                new Dictionary<string, string>
                {
                    {"A","W"},
                    {"B","6"},
                    {"C","N"},
                    {"D","X"},
                    {"E","P"},
                    {"F","?"},
                    {"G","!"},
                    {"H","Q"},
                    {"I","4"},
                    {"J","0"},
                    {"K",","},
                    {"L","8"},
                    {"M","7"},
                    {"N","C"},
                    {"O","U"},
                    {"P","E"},
                    {"Q","H"},
                    {"R","5"},
                    {"S","9"},
                    {"T","2"},
                    {"U","O"},
                    {"V","3"},
                    {"W","A"},
                    {"X","D"},
                    {"Y","Z"},
                    {"Z","Y"},
                    {"0","J"},
                    {"1","."},
                    {"2","T"},
                    {"3","V"},
                    {"4","I"},
                    {"5","R"},
                    {"6","B"},
                    {"7","M"},
                    {"8","L"},
                    {"9","S"},
                    {".","1"},
                    {",","K"},
                    {"?","F"},
                    {"!","G"}
                };

    static Dictionary<string, string> Rotor_20 =
                new Dictionary<string, string>
                {
                    {"A","S"},
                    {"B","F"},
                    {"C","G"},
                    {"D","V"},
                    {"E","8"},
                    {"F","B"},
                    {"G","C"},
                    {"H","Q"},
                    {"I","X"},
                    {"J","3"},
                    {"K","0"},
                    {"L","O"},
                    {"M","7"},
                    {"N","W"},
                    {"O","L"},
                    {"P","4"},
                    {"Q","H"},
                    {"R","?"},
                    {"S","A"},
                    {"T","!"},
                    {"U","9"},
                    {"V","D"},
                    {"W","N"},
                    {"X","I"},
                    {"Y","5"},
                    {"Z","6"},
                    {"0","K"},
                    {"1",","},
                    {"2","."},
                    {"3","J"},
                    {"4","P"},
                    {"5","Y"},
                    {"6","Z"},
                    {"7","M"},
                    {"8","E"},
                    {"9","U"},
                    {".","2"},
                    {",","1"},
                    {"?","R"},
                    {"!","T"}
                };
    static Dictionary<string, string> Reflector =
                new Dictionary<string, string>
                {
                    {"A","M"},
                    {"B","5"},
                    {"C","N"},
                    {"D","T"},
                    {"E","P"},
                    {"F","G"},
                    {"G","F"},
                    {"H","K"},
                    {"I","?"},
                    {"J","Z"},
                    {"K","H"},
                    {"L","9"},
                    {"M","A"},
                    {"N","C"},
                    {"O","."},
                    {"P","E"},
                    {"Q","3"},
                    {"R",","},
                    {"S","X"},
                    {"T","D"},
                    {"U","7"},
                    {"V","!"},
                    {"W","1"},
                    {"X","S"},
                    {"Y","2"},
                    {"Z","J"},
                    {"0","8"},
                    {"1","W"},
                    {"2","Y"},
                    {"3","Q"},
                    {"4","6"},
                    {"5","B"},
                    {"6","4"},
                    {"7","U"},
                    {"8","0"},
                    {"9","L"},
                    {".","O"},
                    {",","R"},
                    {"?","I"},
                    {"!","V"}
                };

    static Dictionary<string, int> Translator =
                new Dictionary<string, int>
                {
                    {"A",1},
                    {"B",2},
                    {"C",3},
                    {"D",4},
                    {"E",5},
                    {"F",6},
                    {"G",7},
                    {"H",8},
                    {"I",9},
                    {"J",10},
                    {"K",11},
                    {"L",12},
                    {"M",13},
                    {"N",14},
                    {"O",15},
                    {"P",16},
                    {"Q",17},
                    {"R",18},
                    {"S",19},
                    {"T",20},
                    {"U",21},
                    {"V",22},
                    {"W",23},
                    {"X",24},
                    {"Y",25},
                    {"Z",26},
                    {"0",27},
                    {"1",28},
                    {"2",29},
                    {"3",30},
                    {"4",31},
                    {"5",32},
                    {"6",33},
                    {"7",34},
                    {"8",35},
                    {"9",36},
                    {".",37},
                    {",",38},
                    {"?",39},
                    {"!",40}
                };
    static Dictionary<int, Dictionary<string, string>> Main_Dictionary =
                new Dictionary<int, Dictionary<string, string>>
                {
                    {0, Rotor_1},
                    {1, Rotor_2},
                    {2, Rotor_3},
                    {3, Rotor_4},
                    {4, Rotor_5},
                    {5, Rotor_6},
                    {6, Rotor_7},
                    {7, Rotor_8},
                    {8, Rotor_9},
                    {9, Rotor_10},
                    {10, Rotor_11},
                    {11, Rotor_12},
                    {12, Rotor_13},
                    {13, Rotor_14},
                    {14, Rotor_15},
                    {15, Rotor_16},
                    {16, Rotor_17},
                    {17, Rotor_18},
                    {18, Rotor_19},
                    {19, Rotor_20},
                    {20, Reflector}
                };


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

        if (!Translator.ContainsKey(input.ToString()))
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

        int NumChar = Translator[input.ToString()];
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



            string OffsetChar = Translator.FirstOrDefault(x => x.Value == CleanOffset).Key;

            string PostConvert = Main_Dictionary[Renderer.selectedIndices[RotorUsed]][OffsetChar];

            int ConvertedInt = Translator[PostConvert];
            ConvertedInt -= RotorRotation;

            if (ConvertedInt < 1)
            {
                ConvertedInt += 40;
            }

            
            return Translator.FirstOrDefault(x => x.Value == ConvertedInt).Key[0];
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