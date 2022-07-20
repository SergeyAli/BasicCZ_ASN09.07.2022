// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

/*
int n = 1244567890;
var stack = new Stack<int>();
while(n > 0) 
{
    stack.Push(n % 10);
    n = n/10; 
    

}   


foreach(var i in stack) Console.Write($"{i}, ");
//object value = System.Console.WriteLine(stack);
*/

System.Console.WriteLine("Введите число ");
string s = Console.ReadLine();
           
            char[] dig_mas = new char[s.Length]; 
            for (int i = 0; i < s.Length; i++)
            {
                dig_mas[i] = s[i];
                //Console.Write(dig_mas[i]);
                
            }
            //Console.ReadLine();
            if (s.Length < 2)
            {
                System.Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine($"Третья цифра в введенном числе\n {dig_mas[2]}");
            }
            

