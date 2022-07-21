// Программа проверяет пятизначное число на палиндромом

//int N=5;
int[] a={1, 2, 3, 2, 1};
//Random random=new Random();//псевдослучайные числа
//for(int i=0;i<a.Length;i++)
   // a[i]=random.Next(1,11);
System.Console.Write("Число ");
//вывод массива
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
//решение задачи
int[] b=new int[a.Length/2];
for(int i=0;i<a.Length/2;i++)
     //b[i]=a[i]*a[a.Length-i-1];
     
//вывод массива 
System.Console.WriteLine();

if (a[0]==a[a.Length-1] & a[1]==a[a.Length-2])
    {
        System.Console.WriteLine("Палиндромом");
    }
    else
    {
        System.Console.WriteLine("Не палиндромом");
    }
//for(int i=0;i<b.Length;i++)
   // System.Console.Write($"{b[i],4}");