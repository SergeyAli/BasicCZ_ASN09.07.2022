// Написать программу возведения числа А в целую степень B - 3

int P(int a, int b)
{
    if (b==0) return 1;
    if (b%2!=0) return P(a,b-1)*a; 
    else  return P(a,b/2)*P(a,b/2);
}

System.Console.WriteLine(P(2,10));
