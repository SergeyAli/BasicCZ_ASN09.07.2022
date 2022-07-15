// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
// Дано число. Проверить кратно ли оно 7 и 23
Console.Write("Введите число a: ");
string userA = Console.ReadLine();
int a = Convert.ToInt32(userA);
Console.Write("Введите число b: ");
string userB = Console.ReadLine();
int b = Convert.ToInt32(userB);
if (a==0 ^ b==0)
{
    System.Console.WriteLine("Введен 0");
}    
 else
{   
 int d;
 d=a%b;

    if (a%b==0)
    {
        System.Console.WriteLine($"{a} кратно {b}");    
    }
    else
    {
        System.Console.WriteLine($"{a} некратно {b} остаток от деления {d}");
    }
}