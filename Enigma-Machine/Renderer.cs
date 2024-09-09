using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using ClickableTransparentOverlay;
using Vortice.DXGI;
using System.Diagnostics;

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
                    output = input;
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

                ImGui.Text(output);
                ImGui.EndTabItem();
            }

            if(ImGui.BeginTabItem("Settings"))
            {
                ImGui.Text("Settings");
                ImGui.EndTabItem();
            }

            ImGui.EndTabBar();

            ImGui.End();
        }
    }
}
