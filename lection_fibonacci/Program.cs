// f(1) = 1
// f(2) = 2
// f(n) = false(n - 1) + false(n - 2)

double Fibonacci(int n)
{
    if(n== 1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for(int i=1; i<50; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}