// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1");
int firstDot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
int secondDot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2");
int thirdDot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
int fourthDot = Convert.ToInt32(Console.ReadLine());
double pointX;
double pointY;

double IntersectionPointOne(int num1, int num2, int num3, int num4)
{
    double intersectionX = Convert.ToDouble(num3 - num1) / (num2 - num4);
    return intersectionX;
}

double IntersectionPointTwo(int num1, int num2, int num3, int num4)
{
    double intersectionY = Convert.ToDouble(num2 * ((num3 - num1) / (num2 - num4)) + num1);
    return intersectionY;
}

if (secondDot == fourthDot)
{
    Console.WriteLine("Такие прямые параллельны");
    return;
}
else
{
    pointX = IntersectionPointOne(firstDot, secondDot, thirdDot, fourthDot);
    pointY = IntersectionPointTwo(firstDot, secondDot, thirdDot, fourthDot);
    Console.WriteLine($"Точка перечения двух прямых будет иметь координаты ({pointX}; {pointY})");
}
