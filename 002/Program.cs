// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)

// полное услове если есть и it и else, если только if то назаваеться не полное условие 

int a,b;
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
s = Console.ReadLine();
b = Convert.ToInt32(s);
// ==, !=, >, <, <=, >=
if (a*a==b)
{
        System.Console.WriteLine("b являеться квадратом a");
}
else
{
    if(b*b==a)
    {
        System.Console.WriteLine("a являеться квадратом b");
    }
    else
    {
        System.Console.WriteLine("Числа не являються квадратами другдруга");
    }
}