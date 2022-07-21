// Написать программу замены элементов массива на противоположные
//Простой вариант
/*
int N=12;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
    
int sumPositive=0;
for(int i=0;i<a.Length;i++)
    if (a[i]>0)
        sumPositive=sumPositive+a[i];

System.Console.WriteLine(sumPositive);    

int sumNegative=0;
for(int i=0;i<a.Length;i++)
    if (a[i]<0)
        sumNegative+=a[i];
        
System.Console.WriteLine(sumNegative);
*/

// Вариант с методом
//инициализация массива
int[] a;
Init(out a,12,100,1000);
//вывод массива (до обработки)
System.Console.WriteLine("Вывод массива до обработки");
Print(a);
System.Console.WriteLine("\nВывод массива после обработки (смены знака)");
//решение задачи
int Negative;  
//int sumNegative;
Solve(a,out Negative);
//Вывод результатов

//System.Console.WriteLine(Negative);          

//System.Console.WriteLine(sumNegative);
void Init(out int[] t, int Length,int min=100,int max=1000) // подпрограмма создания массива
{
  t=new int[Length];
  Random random=new Random();
  for(int i=0;i<t.Length;i++) 
    t[i]=random.Next(min,max+1);
}

void Print(int[] t) // подпрограмма печати
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{t[i],6} ");
}

void Solve(int[] a,out int Negative)
{
    Negative=0;
    
    for(int i=0;i<a.Length;i++)
        {
         a[i] = a[i]-(a[i]*2);
        System.Console.Write($"{a[i],6} ");
        }

    
}

