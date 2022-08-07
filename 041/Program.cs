// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Алгоритм сортировки массива

// double [] arr ={1.1 , 5.3, 4.6, 3, 2.2, 6.6, 7.1, 1.8, 1.9};
double [] arr ={3 , 7, 22, 2, 78};

PrintArray(arr);
SelectionSort(arr); // вызываем упорядочение массива    
PrintArray(arr);
int N = arr.Length; // поиск количества элементов в массиве
double sum = arr[0] + arr[N-1]; // N-1 т.к. индексы нумеруються с 0
System.Console.WriteLine($"Сумма между максимальным и минимальным элементом массива- {sum} ");
double subtract = arr[N-1] - arr[0];
System.Console.WriteLine($"\nРазница между максимальным и минимальным элементом массива- {subtract} ");
void PrintArray(double[] array)  // Составим метод вывода на печать , дадим методу название PrintArray
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");   
    }
    Console.WriteLine();

}


 void SelectionSort(double[] array)  // Метод который упорядочить массив
{
    for (int i = 0; i < array.Length - 1; i++) // т.к. j= i+1, то отнимаем 1 у array.Length что бы получилось обшее количество элементов
    {
        int minPosition = i;
        for (int j = i + 1; j <array.Length; j++) // блок поиска минимального
        {
            if(array[j] < array[minPosition]) minPosition = j; // если поменять знак меньше на больше - массив упорядочиться от большего к меньшему
        }


        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }


}



