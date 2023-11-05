using PolygonController;

internal class Program
{
    private static void Main(string[] args)
    {
        Point A = new Point(-3, 0, "A");
        Point B = new Point(-1, 2, "B");
        Point C = new Point(0, -1, "C");
        Point D = new Point(3, 3, "D");
        Point E = new Point(1, 5, "E");

        Figure triangle = new Figure(A, B, C);
        triangle.CalculatePerimeter();

        Figure rectangle = new Figure(A, B, C, D);
        rectangle.CalculatePerimeter();

        Figure polygone = new Figure(A, B, C, D, E);
        polygone.CalculatePerimeter();

    }
}