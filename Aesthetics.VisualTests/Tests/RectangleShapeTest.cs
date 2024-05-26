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
            Rectangle = new Rectangle() { Width = 100, Height = 100 }
        };
        Canvas.Children.Add(rectangleShape);
    }
}