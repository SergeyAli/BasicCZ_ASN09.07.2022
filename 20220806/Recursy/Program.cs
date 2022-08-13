// Вывести 

// void Loop(int i, int N)
// {
//     System.Console.WriteLine(i);
//     if (i<N) Loop(i+1,N);
// }

// Loop(1,10);

// F!5
void Loop(int i, int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop(i+1,N);
}
{
    int F(int n)
    {
        if (n>0) return F(n-1)*n;
        else return 1;
    }
int N=15;
int f=1;
for (int i = 1; i <=N ; i++)
    f=f*1;
}

Loop(1,10);