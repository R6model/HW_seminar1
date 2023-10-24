// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNaturalNumbers(int numA, int numB)
{
    if (numA == 0) return (numB * (numB + 1)) / 2;
    else if (numB == 0) return (numA * (numA + 1)) / 2;
    else if (numA == numB) return numA;
    else if (numA < numB) return numB + SumNaturalNumbers(numA, numB - 1);
    else return numB + SumNaturalNumbers(numA, numB + 1);
}

Console.Write("Введите первое натуральное число -> ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число -> ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Вы ввели не натуральное число. Повторите ввод");
    return;
}

Console.WriteLine($"Сумма натуральных чисел -> {SumNaturalNumbers(numberM, numberN)}");
