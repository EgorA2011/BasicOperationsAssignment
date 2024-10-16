using System;

class FigureArea
{
    static void Main()
    {
        Console.WriteLine("Выберите фигуру: Квадрат, Круг, Прямоугольник, Треугольник");
        string figure = Console.ReadLine().ToLower();

        switch (figure)
        {
            case "квадрат":
                Console.Write("Введите длину стороны квадрата: ");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площадь квадрата: {side * side}");
                break;

            case "круг":
                Console.Write("Введите радиус круга: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площадь круга: {Math.PI * radius * radius}");
                break;

            case "прямоугольник":
                Console.Write("Введите длину: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Введите ширину: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площадь прямоугольника: {length * width}");
                break;

            case "треугольник":
                Console.Write("Введите длину основания: ");
                double baseTriangle = double.Parse(Console.ReadLine());
                Console.Write("Введите высоту: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площадь треугольника: {baseTriangle * height / 2}");
                break;

            default:
                Console.WriteLine("Неверная фигура.");
                break;
        }
    }
}
