﻿// Вывести на экран числа от -N до N
//int i=-50;
//int N=50;
double i;
double N;
Console.Write("Введите целое число, последовательность которых будеть выводиться с отрецательного до положительного диапазона ");
string? s = Console.ReadLine(); // ввод данных
N=Convert.ToDouble(s);
// защита от неправельного введенного числа
if (N<=0)
{
System.Console.WriteLine("ЧИСЛО ДОЛЖНО БЫТЬ БОЛЬШЕ НУЛЯ");
}
//
i = N - N*2;
while(i<=N)
{
    System.Console.Write($"{i} ");
    i++; // все
    //i=i+2; // четные
}

