public class Square : Shape
{
    public double SideLength { get; set; }
    public override double Area()
    {
        return SideLength * SideLength;
    }
}