using Aesthetics.Base;
using Cabinet;

namespace Aesthetics.VisualTests.Tests;

public class RectangleShapeTest : TestWindow
{
    public RectangleShapeTest()
    {
        var rectangleShape = new RectangleShape()
        {
            Background = Color.FromRgba(255, 0, 0, 255),
            Width = 90,
            Height = 90
        };
        var rectangleShape2 = new RectangleShape()
        {
            Position = new Vector2(100, 0),
            Background = Color.FromRgba(0, 255, 0, 255),
            Width = 90,
            Height = 90
        };
        Canvas.Children.Add(rectangleShape);
        Canvas.Children.Add(rectangleShape2);
    }
}