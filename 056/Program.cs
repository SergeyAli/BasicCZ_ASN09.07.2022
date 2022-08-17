// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

int[,] a = {{1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}};


// int N=3;
// int M=3;

// int [,] a;//описываем массив

// a=new int [N,M];//создаем массив
// //Инициализация случайными числами
// Random random=new Random();//Создали объект типа Random

// for(int i=0;i<a.GetLength(0);i++)
// {
//     for(int j=0;j<a.GetLength(1);j++) 
//     {
//         a[i,j]=random.Next(1,5);
//     }
// }


//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}

int sum=int.MaxValue;
int index=0;
for(int i=0;i<a.GetLength(0);i++)
{
    int temp = 0;
    for(int j=0;j<a.GetLength(1);j++) 
    {
        temp += a[i,j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }       
}
Console.WriteLine($"Строка: {index+1} Сумма строки- {sum}");


