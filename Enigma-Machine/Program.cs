using IMGUI_Renderer;

// start imgui in a seperate thread
Console.WriteLine("Starting ImGui..");
Renderer renderer = new Renderer();
Thread renderThread = new Thread(renderer.Start().Wait);
renderThread.Start();

