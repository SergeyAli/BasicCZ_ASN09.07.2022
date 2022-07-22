// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arr = new int[123];
int k = 0;
Random rnd = new Random();
 
Console.WriteLine("Созданный массив");
for (int i = 0; i < 123; i++)
{
    arr[i] = rnd.Next(0, 1000);
    Console.Write("{0} ", arr[i]);
}
             
foreach(int evenLine in arr)
{
    if (evenLine >= 10 & evenLine <= 99)
    {
    k++;           
    }
}
                        
Console.WriteLine();
Console.WriteLine($"количество элементов из отрезка [10,99] - {k}");


