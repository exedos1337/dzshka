using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Treygoliniki
//{
//    static void Main()
//    {

//        Console.Write("Введите длину первой стороны треугольника: ");
//        double a = Convert.ToDouble(Console.ReadLine());



//        Console.Write("Введите длину второй стороны треугольника: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите длину третьей стороны треугольника: ");
//        double c = Convert.ToDouble(Console.ReadLine());


//        if (!IsValidTriangle(a, b, c))
//        {
//            Console.WriteLine("Такой  треугольник невозможно построить xd.");
//            return;
//        }





//        string triangleType = GetTriangleType(a, b, c);
//        Console.WriteLine($"Тип треугольника: {triangleType}");


//        double area = CalculateArea(a, b, c);
//        Console.WriteLine($"Площадь треугольника: {area:F2}");
//    }


//    static bool IsValidTriangle(double a, double b, double c)
//    {
//        if (a <= 0 || b <= 0 || c <= 0)


//            return false;

//        if ((a + b <= c) || (a + c <= b) || (b + c <= a))

//            return false;

//        return true;
//    }


//    static string GetTriangleType(double a, double b, double c)
//    {
//        if (a == b && b == c)


//            return "Равносторонний треугольник";


//        else if (a == b || a == c || b == c)

//            return "Разносторонний треугольник";

//        else
//            return "Равнобедренный треугольник";
//    }




//    static double CalculateArea(double a, double b, double c)
//    {
//        double p = (a + b + c) / 2;
//        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//    }
//}


class Triygolinkn2
{
    static void Main()
    {
        Console.WriteLine("Введите все стороны треугольника (a, b, c):");

        double a = GetValidInput("a");
        double b = GetValidInput("b");
        double c = GetValidInput("c");
        
        if (!IsTriangle(a, b, c))
        {
            Console.WriteLine("Треугольник не можнт существовать ");
            return;
        }

        string triangleType = GetTriangleType(a, b, c);
        double area = CalculateArea(a, b, c);

        Console.WriteLine($"Вид треугольника: {triangleType}");
        Console.WriteLine($"Площадь треугольника: {area:F2}");
    }

    static double GetValidInput(string sideName)
    {
        double value;
        while (true)
        {
            Console.Write($"Введите длину стороны {sideName}: ");


            if (double.TryParse(Console.ReadLine(), out value) && value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Длина стороны должна быть числом с + числом(0,1,2 и тд).");
            }
        }
    }

    static bool IsTriangle(double a, double b, double c)

    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    static string GetTriangleType(double a, double b, double c)
    {
        double[] sides = { a, b, c };
        Array.Sort(sides);

        double a2 = sides[0] * sides[0];
        double b2 = sides[1] * sides[1];
        double c2 = sides[2] * sides[2];

        if (c2 == a2 + b2)

            return "Прямоугольный треугольник";
        else if (c2 < a2 + b2)

            return "Остроугольный треугольник";
        else

            return "Тупоугольный треугольник";
    }

    static double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        

        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}
