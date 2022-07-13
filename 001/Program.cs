// See https://aka.ms/new-console-template for more information


/*
Console.WriteLine("Hello, World!");
Console.WriteLine(11%3);

int MaxFromToNomber = 0;
double d = 3.14;  // Разделение только точка
Console.WriteLine(int,MaxValue);
Console.WriteLine(double,MaxValue);
string s = "Hello";
char c = 'a'; // В одинарных кавычках храниться только один символ
*/

//С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)

double a;
double b;
Console.Write("Введите целое число, квадрат которого требуеться найти ");
string? s = Console.ReadLine(); // ввод данных
a=Convert.ToDouble(s);
b = a*a; // обратка данных
System.Console.WriteLine("{0}^2={1}",a,b); // строка форматирования
System.Console.WriteLine($"{a}^2={b}"); // строка интерполяции


/*
string? s; // объявии переменную
s=Console.ReadLine(); // присвоили

System.Console.WriteLine(s);
*/


