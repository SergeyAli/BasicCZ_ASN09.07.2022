// Написать программу вычисления функции Аккермана - 5*


// Console.WriteLine("Введите число n:");
// var n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число m:");
// var m = Convert.ToInt32(Console.ReadLine());

static UInt32 A(uint m, uint n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}

System.Console.WriteLine(A(5,0));


