using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using ClickableTransparentOverlay;

namespace IMGUI_Renderer
{
    internal class Renderer : Overlay
    {
        protected override void Render()
        {
            ImGui.Begin("Enigma-Machine Version 1.0");

            ImGui.Text("Testing Testing...");

            ImGui.End();
        }
    }
}
