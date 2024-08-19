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

        string[] A = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", ",", "?", "!"};

        string[] B = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", };

        protected override void Render()
        {

            ImGui.Begin("Enigma-Machine-Disc-Writer");

                for (int i = 0; i < A.Length; i++)
                {
                    ImGui.InputText($"Coded Symbol For: {A[i]}", ref B[i], 1);


                }

                if (ImGui.Button("Update"))
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (B[i] != "")
                    {
                        B[Array.IndexOf(A, B[i])] = A[i];
                    }
                }
            }

                if (ImGui.Button("Post To Console"))
            {
                for (global::System.Int32 i = 0; i < 40; i++)
                {
                    Console.WriteLine("{\"" + A[i] + "\",\"" + B[i] + "\"},");
                }
            }
        }
    }
}