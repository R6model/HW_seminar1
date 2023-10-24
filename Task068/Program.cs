// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int numM, int numN)
{
  if (numM == 0) return numN + 1;
  else if (numN == 0) return AckermanFunction(numM - 1, 1);
  else return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
}

Console.Write ("Введите первое неотрицательное число - > ");
int numberM = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе неотрицательное число - > ");
int numberN = Convert.ToInt32 (Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine ("Вы ввели одно из чисел меньше 0. Повторите ввод");
    return;
}

int Ackerman = AckermanFunction (numberM, numberN);
Console.WriteLine($"Функция Аккермана - > {Ackerman} ");