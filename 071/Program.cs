﻿// Написать программу вычисления функции Аккермана


Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());

static int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}

System.Console.WriteLine(A(m,n));


