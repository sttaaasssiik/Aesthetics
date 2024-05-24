﻿using Cabinet;
using SDL2;

namespace Aesthetics.Rendering;

public class CommandRenderer
{
    internal nint Id { get; }

    internal CommandRenderer(nint id) => Id = id;

    public void FillRectangle(Rectangle rectangle)
    {
        var rect = new SDL.SDL_Rect
        {
            x = rectangle.Position.X,
            y = rectangle.Position.Y,
            w = rectangle.Width,
            h = rectangle.Height
        };
        if (SDL.SDL_RenderFillRect(Id, ref rect) != 0)
        {
            throw new Exception(SDL.SDL_GetError());
        }
    }

    public void SetRenderDrawColor(Color color)
    {
        SDL.SDL_SetRenderDrawColor(Id, color.R, color.G, color.B, color.A);
    }
}