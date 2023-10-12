// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponent(int osn, int exp)
{
    int result = 1;
    for (int i = 0; i < exp; i++)
        {
            checked
            {
                result *= osn;
            }
            
        }
    return result;
}

Console.WriteLine("Введите число А");
int osn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int exp = Convert.ToInt32(Console.ReadLine());
if (exp < 0)
{
    Console.WriteLine("Показатель степени не может быть отрицательным, повторите ввод");
    return;
}
Console.WriteLine($"Число {osn} в степени {exp} равно {Exponent(osn, exp)}");