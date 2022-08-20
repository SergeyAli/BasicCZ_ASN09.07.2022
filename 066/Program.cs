// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine("Введите M");
int M=int.Parse(Console.ReadLine());
// string s=Console.ReadLine();
System.Console.WriteLine("Введите N");
int N=int.Parse(Console.ReadLine());

int P(int M, int N)
{
    if (M==N) return M;
    else return P(M+1,N) + M;
}
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна {P(M,N)}");

