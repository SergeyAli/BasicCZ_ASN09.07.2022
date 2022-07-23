// Показать числа Фибоначчи



Console.Write("Введите конец диапазона чисел Фибоначчи от 1 до : ");
int end=int.Parse(Console.ReadLine());

ComputeF(end, 1);

  void ComputeF(int end, int j)
{
  for(int i=1; i<=end; i+=j)
  {
   Console.Write("{0} ", i);
   j=i-j;
  }

}



