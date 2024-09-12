using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using ClickableTransparentOverlay;
using Vortice.DXGI;
using System.Diagnostics;
using program;

namespace IMGUI_Renderer
{
    internal class Renderer : Overlay
    {

        string input = string.Empty;
        string output = string.Empty;
        int[] selectedIndices = { 1, 2, 3 };
        string[] discs = { "Rotor 1", "Rotor2", "Rotor3", "Rotor4", "Rotor5", "Rotor6", "Rotor7", "Rotor8" };

        protected override void Render()
        {
            ImGui.Begin("Enigma-M3 Version 1.0");

            ImGui.BeginTabBar("Tab Bar");

            if (ImGui.BeginTabItem("Encode/Decode"))
            {
                ImGui.InputText("Text To Convert", ref input, 200);

                if (ImGui.Button("Convert"))
                {
                    output = program.Main.Converter(input);
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

            if (ImGui.BeginTabItem("Settings"))
            {
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

                ImGui.EndTabItem();
            }

            ImGui.EndTabBar();

            ImGui.End();

        }
    }
}

