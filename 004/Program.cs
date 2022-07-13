// По заданному с клавиатуры номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
string userD= Console.ReadLine();
int d = Convert.ToInt32(userD);
string[] weekDays = new string[] {"Понедельник" , "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
System.Console.WriteLine(weekDays[d-1]);
