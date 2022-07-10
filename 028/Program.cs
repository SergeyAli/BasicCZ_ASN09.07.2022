// Определить количество цифр в числе. Сделать подпрограмму.
/*
int N=1264;
int k=0;
while(N!=0)
{
    k++;
    N=N/10;
}

System.Console.WriteLine(k);
*/

int CountDigits(int N)
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
}

System.Console.WriteLine(CountDigits(15));
