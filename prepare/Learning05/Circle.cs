
class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color){
        this._radius = radius;
    }

    public override double GetArea()
    {
        return (Math.PI) * (Math.Pow(_radius,2));
    }
}