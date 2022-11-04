// Найти максимальное из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 21;
int b1 = 56;
int c1 = 45;
int a2 = 234;
int b2 = 1714761;
int c2 = 34;
int a3 = 49;
int b3 = 678;
int c3 = 2596;

// Для наглядности разнесено по строкам
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);