// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число до которого нужно выводить кубы чисел: ");
string userN = Console.ReadLine();
int n = Convert.ToInt32(userN);
double c;
System.Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру");
for(int i = 1; i<=n; i++)
{
    c= (Math.Pow((i), 3));  
   // System.Console.WriteLine(c%2);
   
    if ((c%2)==0)
    {
        System.Console.WriteLine($"| {i} => {c} | ");
    }
}

