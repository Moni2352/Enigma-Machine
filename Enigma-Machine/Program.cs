using Enigma_Machine;
using Renderer;

    // start imgui in a seperate thread
    Renderer renderer = new Renderer();
    Thread renderThread = new Thread(renderer.Start().Wait);
    renderThread.Start();

