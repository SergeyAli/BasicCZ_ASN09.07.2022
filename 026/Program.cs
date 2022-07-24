// Найти сумму чисел от 1 до А
Console.Write("Введите конец арефметической прогресии: ");
int end=int.Parse(Console.ReadLine());
int sum;
SumA(end);

Print(sum,end);

void SumA(int end)
{
    sum = (end*(end+1)/2);
}

void Print(int sum,int end)
{
  System.Console.Write($"Арефметическая прогресия от 1 до {end} будет - {sum}");
}