using ImGuiNET;
using ClickableTransparentOverlay;

namespace IMGUI_Renderer
{

    internal class Renderer : Overlay
    {
        program.Main Program = new program.Main();
        string input = string.Empty;
        string output = string.Empty;
        public static int[] selectedIndices = { 0, 1, 2 };
        string[] discs = { "Rotor1", "Rotor2", "Rotor3", "Rotor4", "Rotor5", "Rotor6", "Rotor7", "Rotor8" };
        public static int[] RotorRotations = { 0, 0, 0 };
        public static string[] Reflector = { "UKWB", "UKWC" };
        public static int CurrentReflector = 0;

        public int PastConverts = 0;
        List<string> PastTexts = [];
        List<string> OtherPastTexts = [];

        protected override void Render()
        {

            ImGui.Begin("Enigma-M3 Version 1.0");

            ImGui.BeginTabBar("Tab Bar");

            if (ImGui.BeginTabItem("Encode/Decode"))
            {
                ImGui.InputText("Text To Convert", ref input, 200);

                if (ImGui.Button("Convert"))
                {
                    output = Program.Converter(input);
                    PastConverts++;
                    PastTexts.Add(output);
                    OtherPastTexts.Add(input);
                    
                }
                ImGui.SameLine();
                if (ImGui.Button("Clear"))
                {
                    input = string.Empty;
                    output = string.Empty;
                }
                ImGui.SameLine();
                if (ImGui.Button("Exit"))
                {
                    Environment.Exit(1);
                }

                ImGui.Text($"Converted Text is: {output}");
                ImGui.EndTabItem();
            }

            if (ImGui.BeginTabItem("Rotor Settings"))
            {
                // ImGui.Text(selectedIndices[0].ToString()); Debugging

                if (ImGui.Button("Reset Rotations"))
                {
                    RotorRotations = [0, 0, 0];
                }
                ImGui.SameLine();

                if (ImGui.Button("Full Reset"))
                {
                    RotorRotations = [0, 0, 0];
                    selectedIndices = [0, 1, 2];
                    CurrentReflector = 0;
                }


                // Rotor Changer
                for (int comboIndex = 0; comboIndex < selectedIndices.Length; comboIndex++)
                {
                    // Display the current selection or "Select..." if none is selected
                    string preview = selectedIndices[comboIndex] >= 0 ? discs[selectedIndices[comboIndex]] : "Select...";
                    if (ImGui.BeginCombo($"Slot {comboIndex + 1}", preview))
                    {
                        for (int i = 0; i < discs.Length; i++)
                        {
                            // Check if the current disc is selected by any other dropdown
                            bool isTaken = false;
                            for (int j = 0; j < selectedIndices.Length; j++)
                            {
                                if (j != comboIndex && selectedIndices[j] == i)
                                {
                                    isTaken = true;
                                    break;
                                }
                            }

                            // Only show selectable items that are not taken
                            if (!isTaken)
                            {
                                bool isSelected = (selectedIndices[comboIndex] == i);
                                if (ImGui.Selectable(discs[i], isSelected))
                                {
                                    selectedIndices[comboIndex] = i; // Update selected index
                                }

                                if (isSelected)
                                {
                                    ImGui.SetItemDefaultFocus();
                                }
                            }
                        }
                    }
                }

                // Rotor Rotator
                ImGui.SliderInt3("Rotations", ref RotorRotations[0], 0, 26);

                // Reflector Changer
                if (ImGui.Combo("Reflector", ref CurrentReflector, Reflector, Reflector.Length))
                {

                }

                ImGui.EndTabItem();
            }

            //if (ImGui.BeginTabItem("PlugBoard Settings"))
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (ImGui.BeginCombo($"Plug {i + 1} Side 1", "Preview"))
            //        {
            //            ImGui.EndCombo();
            //        }

            //        ImGui.SameLine();

            //        if (ImGui.BeginCombo($"Plug {i + 1} Side 2", "Preview"))
            //        {
            //            ImGui.EndCombo();
            //        }
            //    }
            //    ImGui.EndTabItem();
            //}

            if (ImGui.BeginTabItem("Convertion History"))
            {
                if (ImGui.Button("Clear History"))
                {
                    PastConverts = 0;
                    PastTexts = [];
                    OtherPastTexts = [];
                    output = "";
                }
                if (PastConverts != 0)
                {
                    for (int i = 0; i < PastConverts; i++)
                    {
                        ImGui.Text(OtherPastTexts[i] + " --> " + PastTexts[i] + "\n");
                    }
                }
                else
                {
                    ImGui.Text("No Past Conversions");
                }
            }

            ImGui.EndTabBar();

            ImGui.End();

        }


    }
}

