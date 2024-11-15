class Circle:Shape {
    private int _radius;

    public Circle(int radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}