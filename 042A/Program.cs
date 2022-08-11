// Задача 42A
// Даны две квадратных таблицы чисел. Требуется построить третью,
// каждый элемент которой равен сумме элементов, стоящих на том же месте
// в 1-й и 2-й таблицах.

// Входные данные
// Во входном файле записано сначала число N, затем записана первая таблица,
// а после нее - вторая. Элементы таблиц - числа от 0 до 100.
// 100>=N>=1.

int N=3;
int[,] a;//описываем массив
int[,] b;//описываем массив
int[,] c;//описываем массив
a=InitA(N,N);
b=InitB(N,N);
c=InitC(N,N);
System.Console.WriteLine("\nТаблица 1");
Print(a);
System.Console.WriteLine("\nТаблица 2");
Print(b);
Sum(a,b);
System.Console.WriteLine("\nТаблица суммы 1 и 2 таблице");
Print(c);


//Вывод массива на экран
void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],5} ");
            System.Console.WriteLine();
    }
}

int[,] InitA(int N,int M)
{
    a=new int[N,M];//создаем массив
    //Инициализация случайными числами
    Random random=new Random();//Создали объект типа Random

    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) 
        {
            a[i,j]=random.Next(1,100);
        }
    }
    return a;
}

int[,] InitB(int N,int M)
{
    b=new int[N,M];//создаем массив
    //Инициализация случайными числами
    Random random=new Random();//Создали объект типа Random

    for(int i=0;i<b.GetLength(0);i++)
    {
        for(int j=0;j<b.GetLength(1);j++) 
        {
            b[i,j]=random.Next(1,100);
        }
    }
    return b;
}

int[,] InitC(int N,int M)
{
    c=new int[N,M];//создаем массив
    //Инициализация случайными числами
    Random random=new Random();//Создали объект типа Random

    for(int i=0;i<c.GetLength(0);i++)
    {
        for(int j=0;j<c.GetLength(1);j++) 
        {
            c[i,j]=random.Next(1,100);
        }
    }
    return c;
}
//Решить задачу
void Sum(int[,] a, int[,] b)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) 
        c[i,j] = a[i,j] + b[i,j];
    }
}
