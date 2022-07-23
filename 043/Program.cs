// Определить сколько чисел больше 0 введено с клавиатуры

/*
System.Console.WriteLine("Введите числа через - ENTER, по окончании ввода наберите - ent");
string a;
int[] b = new int[100];
int i=0;
 
while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
    b[i++] = Convert.ToInt32(a); //в стркое нет "конца" - значит конвертим и пишем в массив
 
for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
    Console.Write($"{b[k]} ");

int[] t;//объявление
//инициализация
//Init(out t,8,max:100);
//решение задачи
//вывод результатов на экран
Print(t,"t");



void Print(int[] t)
{
    for (int i = 0; i < t.Length; i++)       
    System.Console.WriteLine($"a[{i}]={t[i]}");
}
Print(t);
*/

Console.Write("Введите элементы(через пробел, в конце ввода нажмите ENTER): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

ArNol(arr,0);

//int count;

void ArNol(int[] arr, int count)
{
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 

Console.WriteLine($"Кол-во элементов > 0: {count}");

}
