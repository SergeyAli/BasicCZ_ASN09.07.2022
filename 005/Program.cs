// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.Write("Введите первое число: ");
string userA = Console.ReadLine();
int a = Convert.ToInt32(userA);
Console.Write("Введите второе число: ");
string userB = Console.ReadLine();
int b = Convert.ToInt32(userB);
Console.Write("Введите третье число: ");
string userC = Console.ReadLine();
int c = Convert.ToInt32(userC);
int max = a;
if(a > max ) max = a;
if(b > max ) max = b;
if(c > max ) max = c;
Console.Write("max = ");
Console.Write(max);
