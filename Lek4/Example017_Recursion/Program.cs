// Примеры рекурсии

// int Factorial(int n)
// {
//     if (n == 0) return 1;
//     else return n * Factorial(n -1);
// }

// System.Console.WriteLine(Factorial(3));

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}