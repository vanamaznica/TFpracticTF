using System;

interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

class Circle : IShape
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : IShape
{
    double width, height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea()
    {
        return width * height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}

class Triangle : IShape
{
    double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public double CalculatePerimeter()
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);
        IShape triangle = new Triangle(3, 4, 5);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(triangle.CalculateArea());
        Console.WriteLine(triangle.CalculatePerimeter());
    }
}