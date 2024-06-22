class Circle: Roundshape
{

    protected double radius;

    public Circle(double r) {radius = r;  }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }


}