﻿
public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return 0.5 * Base * Height;
    }
}