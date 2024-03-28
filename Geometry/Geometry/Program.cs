class ProgramGeometry
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle { Height = 2, Width = 2 };
        Circle circle = new Circle { Radius = 2 };
        Triangle triangle = new Triangle { Base = 1, Height = 1 };
        Square square = new Square { SideLength = 2 };
        Shape[] arrShapes = { rectangle, circle, triangle, square };
        AreaCalculator calculator = new AreaCalculator();
        Console.WriteLine("Surface totale : " + calculator.TotalArea(arrShapes));
    }

    public class AreaCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var shape in arrShapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}