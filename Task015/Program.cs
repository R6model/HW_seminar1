// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
int VyhodnoyFirst = 6;
int VyhodnoySecond = 7;

if (number > 7 && number < 1) 
{
Console.WriteLine("Дня недели с таким номером не существует");
}    
else if (number == VyhodnoyFirst)
{
Console.WriteLine("Это выходной");
}
else if (number == VyhodnoySecond)
{
Console.WriteLine("ЭЭто выходной");
}
else if (number <=5)
{
 Console.WriteLine("Это рабочий день");
}
   







