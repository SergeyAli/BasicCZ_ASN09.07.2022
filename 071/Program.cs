// Написать программу вычисления функции Аккермана - 5*


// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());

// static Uint32 A(uint m, uint n)
// {
//   if (m == 0)
//     return n + 1;
//   else
//     if ((m != 0) && (n == 0))
//       return A(m - 1, 1);
//     else
//       return A(m - 1, A(m, n - 1));
// }

// System.Console.WriteLine(A(4,1));


    using System;
     
    namespace ConsoleApp
    {
        class Program
        {
            public static int Depth = 0;
            public static UInt64 AckermannFunc(UInt64 m, UInt64 n) 
            {
                Depth++;
                if (m == 0)
                    return n + 1;
                if (n == 0)
                    return AckermannFunc(m - 1, 1);
                return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
            }
     
            static void Main(string[] args) {
                Console.WriteLine(AckermannFunc(3, 5));
                Console.WriteLine(Depth);
            }
        }
    }