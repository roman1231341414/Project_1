Console.Clear();
double f(int n)
{
    if(n == 1) return 1;
    else return f(n-1) + f(n-2);
}

for(int i = 1;i < 10; i++)
{
    Console.WriteLine(f(i));
}