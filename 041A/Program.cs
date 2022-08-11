// Задача 41A
// Дана квадратная матрица. Проверить, является ли она симметричной относительно
// главной диагонали.

int[,] a = new int[,] // Создаем матрицу и заполняем данными
{
    {0, 1, 2, 4, 6},
    {1, 1, 3, 5, 7},
    {2, 3, 0, 9, 8},
    {4, 5, 9, 1, 1},
    {6, 7, 8, 1, 0},
};
//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}
var temp=0; // Переменная для определения выполнения или не выполнения условия
for (int i = 0; i < a.GetLength(0); i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
        if (a[i,j] != a[j,i]) 
        temp=1;
        break;
        
}
if( temp == 1) Console.WriteLine("Не семитрична");
else
Console.WriteLine("Cемитрична"); 