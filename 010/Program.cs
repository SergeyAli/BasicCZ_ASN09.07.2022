// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.
//int a=45612;
Console.Write("Введите число: ");
string userA = Console.ReadLine();
int a = Convert.ToInt32(userA);
if (a<10)
{
    System.Console.WriteLine(a);
}
else
{
    int c = a%10;
    System.Console.WriteLine(c);  
}
    