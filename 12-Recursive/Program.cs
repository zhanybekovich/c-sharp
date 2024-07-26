// factorial
int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(4));
Console.WriteLine(Factorial(5));

// fibonachi
int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;

    return Fibonachi(n-1) + Fibonachi(n-2);
}

Console.WriteLine(Fibonachi(4));
Console.WriteLine(Fibonachi(5));