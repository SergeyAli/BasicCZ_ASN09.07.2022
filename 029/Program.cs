// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b=a;
int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a /10 ;
}
 Console.WriteLine($"Сумма числа {b} будет {sum}");

