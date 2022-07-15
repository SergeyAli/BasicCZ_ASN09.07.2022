// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Write("Введите значения координаты X: ");
string userA = Console.ReadLine();
int a = Convert.ToInt32(userA);
Console.Write("Введите значения координаты Y: ");
string userB = Console.ReadLine();
int b = Convert.ToInt32(userB);
if (a==0 ^ b==0)
{
    System.Console.WriteLine("Введена нулевая координата");
}
else
{
    if (a>0 & b>0)
    {
        System.Console.WriteLine("Координаты первой четверти");
    }
    else
    {
        if (a<0 & b>0)
        {
            System.Console.WriteLine("Координаты второй четверти");
        }
        else
        {
            if (a<0 & b<0)
            {
                System.Console.WriteLine("Координаты третьей четверти");
            }
            else
            {
                System.Console.WriteLine("Координаты четвертой четверти");
            }  
        }  
    }  
}
