﻿using Aesthetics.Base;
using Aesthetics.Controls;
using Cabinet;

namespace Aesthetics.VisualTests;

public class TestDotMatrixDisplay : Window
{
    private readonly DotMatrixDisplay dotMatrixDisplay = new(new Vector2(10, 20), new Vector2(20, 20))
    {
        Background = Color.FromRgba(20, 20, 20, 255),
        Position = new Vector2(100, 100)
    };

    public TestDotMatrixDisplay()
    {
        Canvas.Children.Add(dotMatrixDisplay);
        var dots = new List<(Vector2, Color)>()
        {
            (new Vector2(0, 0), Color.FromRgba(200, 0, 0, 255)),
            (new Vector2(9, 9), Color.FromRgba(200, 0, 0, 255)),
        };
        dotMatrixDisplay.Dots = dots;
    }
}