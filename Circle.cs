namespace Lab5;

class Circle
{
    private double _radius;
    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }


    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        // If radius is greater than 0
        if (radius > 0)
        {
            this.Radius = radius;
        }
        else
        {
            // Else error
            throw new InvalidRadiusException(radius);
        }
    }

    public string ToString()
    {
        return $"Circle with radius {this.Radius}";
    }

}






