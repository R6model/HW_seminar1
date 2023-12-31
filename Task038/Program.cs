﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}; ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.WriteLine("]");
}

double DifferenceNumbers(double[] arr)
{
     double dif = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        double min = arr[i];
        double max = 0; 
        if (arr[i] <= min) min = arr[i];
        if (arr[i]>max)max=arr[i]; 
        dif = max - min;                  
    }
    return dif;
    
}





double[] array = CreateArrayRndDouble(4, 1, 8);
PrintArray(array);
double difference = DifferenceNumbers(array);
Console.Write($"->{difference:F2}");