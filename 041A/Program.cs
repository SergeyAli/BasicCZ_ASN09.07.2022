// Задача 41A
// Дана квадратная матрица. Проверить, является ли она симметричной относительно
// главной диагонали.

int N=3;

int [,] a;//описываем массив

a=new int [N,N];//создаем массив
//Инициализация случайными числами
Random random=new Random();//Создали объект типа Random

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.Next(1,5);
    }
}


//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}

//int sum1=0;
//int sum2=0;

for (int i = 0; i < a.GetLength(0); i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
        if (a[i,j] != a[j,i]) Console.WriteLine($"{a[i,j]} и {a[j,i]} Не семитрична");
     //sum1=sum1+a[i,i];
    //sum2=sum2+a[i,N-i-1];   
}
//System.Console.WriteLine(sum1);
//System.Console.WriteLine(sum2);
Console.WriteLine("Cемитрична");