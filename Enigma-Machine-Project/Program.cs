using IMGUI_Render;

public class Program
{
    private static void Main(string[] args)
    {
        // start imgui in a seperate thread
        Renderer renderer = new Renderer();
        Thread renderThread = new Thread(renderer.Start().Wait);
        renderThread.Start();
    }


}