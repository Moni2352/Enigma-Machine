using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using IMGUI_TEST;
using ImGuiNET;

namespace IMGUI_TEST
{
    public class Renderer : Overlay
    {

        string[] discs = { "Rotor I", "Rotor II", "Rotor III", "Rotor IV", "Rotor V" };
        int[] selectedIndices = { 0, 1, 2 }; // Indices for the selected elements in each dropdown

        protected override void Render()
        {
            // Draw stuff here
            ImGui.Begin("Enigma-Machine | Version 0.1");

            ImGui.BeginTabBar("Tabs");
            if (ImGui.BeginTabItem("Conversion"))
            {
                ImGui.Text("1");
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
                        ImGui.EndCombo();
                    }
                }

                // selectedIndices now contains the indices of the selected elements for each dropdown



                ImGui.EndTabItem();
            }
            
            ImGui.EndTabBar();

            ImGui.End();

        }
    }
}