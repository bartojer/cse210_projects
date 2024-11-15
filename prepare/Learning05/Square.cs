class Square:Shape {

    private int _side;
    public Square(int side, string color) : base(color)
    {
        _side = side;
        _color = color;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}