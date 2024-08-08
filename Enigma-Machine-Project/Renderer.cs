using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using IMGUI_Render;
using functions;
using ImGuiNET;




namespace IMGUI_Render
{
    public class Renderer : Overlay
    {
        Program_Main Programs = new Program_Main();

        string[] discs = { "Rotor I", "Rotor II", "Rotor III", "Rotor IV", "Rotor V" };
        public static int[] selectedIndices = [0, 1, 2]; // Indices for the selected elements in each dropdown
        public static int Rotation_A = 1;
        public static int Rotation_B = 1;
        public static int Rotation_C = 1;

        public static string textinput = string.Empty;
        string ConvertedText = "hello";
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
                // Drop Down Menus

                ImGui.SliderInt("Rotation of Rotor A", ref Rotation_A, 1, 26);
                ImGui.SliderInt("Rotation of Rotor B", ref Rotation_B, 1, 26);
                ImGui.SliderInt("Rotation of Rotor C", ref Rotation_C, 1, 26);

                if (ImGui.Button("Reset Settings"))
                {
                    selectedIndices = [0,1,2];
                    Rotation_A = 1;
                    Rotation_B = 1;
                    Rotation_C = 1;
                }

                ImGui.EndTabItem();
            }
            
            ImGui.EndTabBar();

            ImGui.End();

        }
    }
}