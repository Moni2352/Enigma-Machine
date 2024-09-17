using IMGUI_Renderer;

// start imgui in a seperate thread
Console.WriteLine("Starting ImGui..");
Renderer renderer = new Renderer();
Thread renderThread = new Thread(renderer.Start().Wait);
renderThread.Start();



namespace program
{
    public class Main
    {

        public int[][] RotorTurn = { [18, 18], [6, 6], [23, 23], [11, 11], [1, 1], [1, 14], [1, 14], [1, 14] };

        public void Increment()
        {
            Renderer.RotorRotations[2]++;

            if (Renderer.RotorRotations[2] == RotorTurn[Renderer.selectedIndices[2]][0] || Renderer.RotorRotations[2] == RotorTurn[Renderer.selectedIndices[2]][1])
            {
                Renderer.RotorRotations[1]++;
                if (Renderer.RotorRotations[1] == RotorTurn[Renderer.selectedIndices[1]][0] || Renderer.RotorRotations[1] == RotorTurn[Renderer.selectedIndices[1]][1])
                {
                    Renderer.RotorRotations[0]++;
                }
            }

            if (Renderer.RotorRotations[2] == 27)
            {
                Renderer.RotorRotations[2] = 0;
            }

            if (Renderer.RotorRotations[1] == 27)
            {
                Renderer.RotorRotations[1] = 0;
            }

            if (Renderer.RotorRotations[0] == 27)
            {
                Renderer.RotorRotations[0] = 0;
            }
        }


        public string Converter(string input)
        {
            string output = null;

            for (int i = 0; i < input.Length; i++)
            {
                Increment();
                // Code
                // Add
            }

            return output;
        }

        

    }



}