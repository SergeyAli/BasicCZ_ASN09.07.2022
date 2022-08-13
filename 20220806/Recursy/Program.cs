// Вывести 

void Loop(int i, int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop(i+1,N);
}

Loop(1,10);