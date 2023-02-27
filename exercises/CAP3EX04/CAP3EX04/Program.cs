using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        double x, y, area, perimetro, diagonal;

        x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = x * y;

        perimetro = x + x + y + y ;

        diagonal = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));

        Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL  = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
    }
}