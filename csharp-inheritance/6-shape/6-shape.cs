using System;

/// <summary>
/// Represents a base shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Computes the area of the shape.
    /// </summary>
    /// <returns>Throws a NotImplementedException.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// Represents a rectangle, inheriting from Shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0.");
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0.");
            height = value;
        }
    }
}
