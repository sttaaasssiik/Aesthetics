using Aesthetics.Rendering;
using SDL2;

namespace Aesthetics.Base;

public class Window : ContentElement
{
    private nint windowImpl;

    private bool running = true;

    //public Canvas Canvas { get; } = new();


    //public event RenderEvent? RenderEvent;

    protected DrawingContext DrawingContext { get; private set; } = null!;

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
                        OnUIEvent(new UIEventArgs() { SDL_Event = e });
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

            DrawingContext = new DrawingContext(rendererId);

            SDL.SDL_SetRenderDrawBlendMode(DrawingContext.Id, SDL.SDL_BlendMode.SDL_BLENDMODE_BLEND);
        }

        void CleanUp()
        {
            SDL.SDL_DestroyRenderer(DrawingContext.Id);
            SDL.SDL_DestroyWindow(windowImpl);
            SDL.SDL_Quit();
        }

        Setup();
        while (running)
        {
            PollEvents();
            DrawingContext.SetRenderDrawColor(Background);
            DrawingContext.Clear();
            Content?.OnRender(DrawingContext);
            //RenderEvent?.Invoke(DrawingContext);
            DrawingContext.Present();
        }
        CleanUp();
    }
}