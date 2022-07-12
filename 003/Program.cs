// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
Console.Write("Введите число a: ");
string userA = Console.ReadLine();
int a = Convert.ToInt32(userA);
Console.Write("Введите число b: ");
string userB = Console.ReadLine();
int b = Convert.ToInt32(userB);
int max = a;
if(a > max ) max = a;
if(b > max ) max = b;
Console.Write("max = ");
Console.Write(max);