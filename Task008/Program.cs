//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine ("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (n<=0)
{
   Console.WriteLine ("Введено некорректное число N"); 
}
else
{
    while (count <= n)
    {
        if (count%2==0)
        {
        Console.Write($"{count} ");
        }
    count++;
    }
}

