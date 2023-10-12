// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите терхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 999 && number > 100)
{
    int SecondNum = number / 10 % 10;
    Console.WriteLine($"Вторая цифра введенного числа -> {SecondNum}");
}
else
{
    Console.WriteLine("Введено некорректное число, повторите ввод");
    return;
}