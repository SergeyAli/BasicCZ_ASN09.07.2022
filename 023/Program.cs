// Найти расстояние между точками в пространстве 2D

Console.Write("ВВведите координату точки  x1: ");
string userX1 = Console.ReadLine();
int x1 = Convert.ToInt32(userX1);
Console.Write("Введите координату точки  x1: ");
string userX2 = Console.ReadLine();
int x2 = Convert.ToInt32(userX2);
Console.Write("ВВведите координату точки  y1: ");
string userY1 = Console.ReadLine();
int y1 = Convert.ToInt32(userY1);
Console.Write("Введите координату точки  y1: ");
string userY2 = Console.ReadLine();
int y2 = Convert.ToInt32(userY2);
double c;
c= Math.Sqrt((Math.Pow((x2-x1), 2))+(Math.Pow((y2-y1), 2)));
System.Console.WriteLine($"Расстояние между точками равно {c}");
