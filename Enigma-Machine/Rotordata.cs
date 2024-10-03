﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    public class Rotordata
    {
        Dictionary<string, string> Rotor1 = new Dictionary<string, string>()
        {
           { "A", "E"},
           { "B", "K"},
           { "C", "M"},
           { "D", "F"},
           { "E", "L"},
           { "F", "G"},
           { "G", "D"},
           { "H", "Q"},
           { "I", "V"},
           { "J", "Z"},
           { "K", "N"},
           { "L", "T"},
           { "M", "O"},
           { "N", "W"},
           { "O", "Y"},
           { "P", "H"},
           { "Q", "X"},
           { "R", "U"},
           { "S", "S"},
           { "T", "P"},
           { "U", "A"},
           { "V", "I"},
           { "W", "B"},
           { "X", "R"},
           { "Y", "C"},
           { "Z", "J"}
        };

        Dictionary<string, string> Rotor2 = new Dictionary<string, string>()
        {
           { "A", "A"},
           { "B", "J"},
           { "C", "D"},
           { "D", "K"},
           { "E", "S"},
           { "F", "I"},
           { "G", "R"},
           { "H", "U"},
           { "I", "X"},
           { "J", "B"},
           { "K", "L"},
           { "L", "H"},
           { "M", "W"},
           { "N", "T"},
           { "O", "M"},
           { "P", "C"},
           { "Q", "Q"},
           { "R", "G"},
           { "S", "Z"},
           { "T", "N"},
           { "U", "P"},
           { "V", "Y"},
           { "W", "F"},
           { "X", "V"},
           { "Y", "O"},
           { "Z", "E"}
        };

        Dictionary<string, string> Rotor3 = new Dictionary<string, string>()
        {
           { "A", "B"},
           { "B", "D"},
           { "C", "F"},
           { "D", "H"},
           { "E", "J"},
           { "F", "L"},
           { "G", "C"},
           { "H", "P"},
           { "I", "R"},
           { "J", "T"},
           { "K", "X"},
           { "L", "V"},
           { "M", "Z"},
           { "N", "N"},
           { "O", "Y"},
           { "P", "E"},
           { "Q", "I"},
           { "R", "W"},
           { "S", "G"},
           { "T", "A"},
           { "U", "K"},
           { "V", "M"},
           { "W", "U"},
           { "X", "S"},
           { "Y", "Q"},
           { "Z", "O"}
        };


    }
}
