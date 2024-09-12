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

        protected override void Render()
        {
            ImGui.Begin("Enigma-M3 Version 1.0");

            

            ImGui.BeginTabBar("Tab Bar");

            if(ImGui.BeginTabItem("Encode/Decode"))
            {
                ImGui.InputText("Text To Convert", ref input, 200);

                if (ImGui.Button("Convert"))
                {
                    output = program.Main.Converter(input);
                }
                ImGui.SameLine();
                if(ImGui.Button("Clear"))
                {
                    input = string.Empty;
                    output = string.Empty;
                }
                ImGui.SameLine();
                if(ImGui.Button("Exit"))
                {
                    Environment.Exit(1);
                }

                ImGui.Text($"Converted Text is: {output}");
                ImGui.EndTabItem();
            }

            if(ImGui.BeginTabItem("Settings"))
            {
                


                ImGui.EndTabItem();
            }

            ImGui.EndTabBar();

            ImGui.End();
        }
    }
}
