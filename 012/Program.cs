// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите числоиз  диапазона  [10, 99]: ");
string userA = Console.ReadLine();
int a = Convert.ToInt32(userA);
int b = 0;
            for (; a !=0; a/=10)
            {
                int c = a % 10;
                if (c > b) b = c;
            }
System.Console.WriteLine("Наибольшая цифра числа");
System.Console.WriteLine(b);