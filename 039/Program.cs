// Найти сумму чисел одномерного массива стоящих на нечетной позиции







//решение задачи
int s=0;
for(int i=0;i<a.Length;i++)
    if (i%2!=0)
        s=s+a[i];

System.Console.WriteLine(s);
