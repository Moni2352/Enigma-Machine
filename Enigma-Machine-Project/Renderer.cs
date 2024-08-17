using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using IMGUI_Render;
using ImGuiNET;




namespace IMGUI_Render
{
    public class Renderer : Overlay
    {
        Program Programs = new Program();

        string[] discs = { "Rotor 1", "Rotor 2", "Rotor 3", "Rotor 4", "Rotor 5", "Rotor 6", "Rotor 7", "Rotor 8", "Rotor 9", "Rotor 10", "Rotor 11", "Rotor 12", "Rotor 13", "Rotor 14", "Rotor 15", "Rotor 16", "Rotor 17", "Rotor 18", "Rotor 19", "Rotor 20" };
        public static int[] selectedIndices = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]; // Indices for the selected elements in each dropdown

        public static int NumOfRotors = 3;

        public static int[] RotorRotations = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public static string[] RotorNames = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

        string textinput = string.Empty;
        string ConvertedText = "";
        protected override void Render()
        {
            // Draw stuff here
            ImGui.Begin("Enigma-Machine | Version 0.1");

            ImGui.BeginTabBar("Tabs");
            if (ImGui.BeginTabItem("Conversion"))
            {
                ImGui.InputText("Text to Convert", ref textinput, 500);
                if (ImGui.Button("Convert"))
                {
                    ConvertedText = Programs.Convert(textinput);
                }

                ImGui.Text($"Converted Text: {ConvertedText}");

                if(ImGui.Button("Exit"))
                {
                    Environment.Exit(0);
                }

                ImGui.EndTabItem();
            }

            if (ImGui.BeginTabItem("Settings"))
            {

                ImGui.SliderInt("Number Of Rotors", ref NumOfRotors, 3, 10);

                for (int comboIndex = 0; comboIndex < NumOfRotors; comboIndex++)
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
                        ImGui.EndCombo();
                    }
                }
                // Drop Down Menus

            
                for (int RotationIndex = 0; RotationIndex < NumOfRotors; RotationIndex++)
                {
                    ImGui.SliderInt($"Rotation Of Rotor {RotorNames[RotationIndex]}", ref RotorRotations[RotationIndex], 0, 40);
                }

                if (ImGui.Button("Reset Settings"))
                {
                    NumOfRotors = 3;
                    selectedIndices = [0,1,2, 3, 4, 5, 6, 7, 8, 9];

                    for (int i = 0; i < 10; i++)
                    {
                        RotorRotations[i] = 0;
                    }
                }

                ImGui.EndTabItem();
            }
            
            ImGui.EndTabBar();

            ImGui.End();

        }
    }
}