using System;

class ProgramGeometry
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle { Height = 2, Width = 2 };
        Circle circle = new Circle { Radius = 2 };
        Triangle triangle = new Triangle { Base = 1, Height = 1 };
        object[] arrObjects = { rectangle, circle, triangle };
        Console.WriteLine("Surface totale : " + TotalArea(arrObjects));
    }

    public static double TotalArea(object[] arrObjects)
    {
        double area = 0;
        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
            {
                Rectangle objRectangle = (Rectangle)obj;
                area += objRectangle.Height * objRectangle.Width;
            }
            else if (obj is Circle)
            {
                Circle objCircle = (Circle)obj;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
            else if (obj is Triangle)
            {
                Triangle objTriangle = (Triangle)obj;
                area += 0.5 * objTriangle.Base * objTriangle.Height;
            }
        }
        return area;
    }
}