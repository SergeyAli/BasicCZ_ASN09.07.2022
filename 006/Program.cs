// Написать программу вычисления значения функции y = sin(a). (Класс Math)
/*
double x,y;
x = Math.PI; // константа чесла числа Пи
y = Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");
*/



// Тип возвращаемого значения Имя_функции (аргумент функции)
double Sin(double x) //методы
{
    return Math.Sin(x);
}

double Sum(double a,double b) 
{
    return a+b;
}


void Pause() // метод
{
    System.Console.WriteLine("Press any key");

}
double y = Sin(3.14);
System.Console.WriteLine(y);

Pause();
// System.Console.WriteLine(Pause());