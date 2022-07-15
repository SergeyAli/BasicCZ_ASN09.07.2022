// Вывести на экран кубы чисел от 1 до N
Console.Write("Введите число до которого нужно выводить таблицу кубов: ");
string userN = Console.ReadLine();
int n = Convert.ToInt32(userN);
double c;
for(int i = 1; i<=n; i++)
{
    c= (Math.Pow((i), 3));  
    System.Console.WriteLine($"| {i} => {c} | ");
}