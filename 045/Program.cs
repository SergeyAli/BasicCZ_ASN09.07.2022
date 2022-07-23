// See Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
double x;//объявление
double y;
//инициализация
Intersection(-5,7,-90,7);
//решение задачи
//вывод результатов на экран
Print(x,y);


void Intersection(double k1, double k2,double b1, double b2)  
{
    x=((b2-b1)/(k1-k2));
    y=k1*x+b1;
}

void Print(double x,double y)
{
  System.Console.Write($"Точка пересечения двух прямых X ={x}, Y={y}");
}

