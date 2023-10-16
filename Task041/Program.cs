// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] MassiveOfNumbers(int size)
{
    int[] PosNum = new int[size];
    for (int i = 0; i < PosNum.Length; i++)
    {
        Console.WriteLine("Введите число:");
        PosNum[i] = Convert.ToInt32(Console.ReadLine());
    }
    return PosNum;
}

void PositiveNumbers(int [] PosNum)
{
    int sum = 0;
    for (int i = 0; i < PosNum.Length; i++)
    {
        if (PosNum[i] > 0) sum++;
    }
    Console.Write($"{sum}");
}

void PrintArray(int[] PosNum)
{
    Console.Write("[");
    for (int i = 0; i < PosNum.Length; i++)
    {
        if (i < PosNum.Length - 1) Console.Write($"{PosNum[i]}, ");
        else Console.Write($"{PosNum[i]}");
    }
    Console.WriteLine("]");
}


Console.Write("Сколько чисел хотите ввести?");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] UsersInput = MassiveOfNumbers(numbers);
Console.Write("Вы ввели следующие числа ->");
PrintArray(UsersInput);
Console.Write($"Из них положительных:");
PositiveNumbers(UsersInput);
