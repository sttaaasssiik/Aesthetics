using Aesthetics.Rendering;
using SDL2;

namespace Aesthetics.Base;

public class Window
{
    private nint windowImpl;

    private bool running = true;

    public Canvas Canvas { get; } = new();

    public event WindowEvent? WindowEvent;

    public event RenderEvent? RenderEvent;

    protected CommandRenderer Renderer { get; private set; } = null!;

    public void Run()
    {
        void PollEvents()
        {
            while (SDL.SDL_PollEvent(out SDL.SDL_Event e) == 1)
            {
                switch (e.type)
                {
                    case SDL.SDL_EventType.SDL_QUIT:
                        running = false;
                        break;
                    default:
                        WindowEvent?.Invoke(e);
                        break;
                }
            }
        }

        void Setup()
        {
            windowImpl = SDL.SDL_CreateWindow(
                "SDL .NET 6 Tutorial",
                SDL.SDL_WINDOWPOS_UNDEFINED,
                SDL.SDL_WINDOWPOS_UNDEFINED,
                640,
                640,
                SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            if (windowImpl == nint.Zero)
            {
                Console.WriteLine($"There was an issue creating the window. {SDL.SDL_GetError()}");
            }

            var rendererId = SDL.SDL_CreateRenderer(
                windowImpl,
                -1,
                SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED |
                SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);

            if (rendererId == nint.Zero)
            {
                Console.WriteLine($"There was an issue creating the renderer. {SDL.SDL_GetError()}");
            }

            Renderer = new CommandRenderer(rendererId);

            SDL.SDL_SetRenderDrawBlendMode(Renderer.Id, SDL.SDL_BlendMode.SDL_BLENDMODE_BLEND);
        }

        void CleanUp()
        {
            SDL.SDL_DestroyRenderer(Renderer.Id);
            SDL.SDL_DestroyWindow(windowImpl);
            SDL.SDL_Quit();
        }

        Setup();
        while (running)
        {
            PollEvents();
            foreach (var child in Canvas.Children)
            {
                child.Render(Renderer);
            }
            RenderEvent?.Invoke(Renderer);
            SDL.SDL_RenderPresent(Renderer.Id);
        }
        CleanUp();
    }
}