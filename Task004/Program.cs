// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine ("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if (numberTwo>max&&numberTwo>numberThree)
{
    Console.Write ($"a={numberOne} b={numberTwo} c={numberThree} -> max={numberTwo}");
}
else
{
    Console.Write ($"a={numberOne} b={numberTwo} c={numberThree} -> max={numberThree}");
}