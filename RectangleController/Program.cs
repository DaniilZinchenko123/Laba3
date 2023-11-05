using RectangleController;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double side1, side2;
        bool validInput = false;

        do
        {
            Console.Write("Введіть довжину першої сторони прямокутника: ");
            if (double.TryParse(Console.ReadLine(), out side1) && side1 > 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Неправильний ввід. Будь ласка, введіть числове значення.");
            }
        } while (!validInput);

        validInput = false;

        do
        {
            Console.Write("Введіть довжину другої сторони прямокутника: ");
            if (double.TryParse(Console.ReadLine(), out side2) && side2 > 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Неправильний ввід. Будь ласка, введіть числове значення.");
            }
        } while (!validInput);

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
    }
}