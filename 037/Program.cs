//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел


int[] arr = new int[12];
int k = 0;
Random rnd = new Random();
 
Console.WriteLine("Созданный массив");
for (int i = 0; i < 12; i++)
{
    arr[i] = rnd.Next(100, 999);
    Console.Write("{0} ", arr[i]);
}
             
foreach(int amtEven in arr)
{
    if (amtEven % 2 == 0)
    {
    k++;           
    }
}
                        
Console.WriteLine();
Console.WriteLine("Количество четных элементов {0}\nКоличество не четных элементов {1}", k, (12-k));


