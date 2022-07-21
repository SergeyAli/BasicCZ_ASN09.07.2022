// Программа проверяет пятизначное число на палиндромом

int[] a={1, 2, 3, 2, 1};
System.Console.Write("Число ");
//вывод массива
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
//решение задачи
int[] b=new int[a.Length/2];
for(int i=0;i<a.Length/2;i++)
   
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
