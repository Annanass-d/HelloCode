// Виды методов

// Вид 1 - ничего не принимает, ничего не возвращает

void Method1()
{
    System.Console.WriteLine("Автор ...");
}
// Method1();



// Вид 2 - что-то принимает, ничего не возвращает

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
    
}
// Method21(msg: "Текст сообщения", count: 4); // именованные аргументы



// Вид 3 - ничего не принимает, что-то возвращает

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// System.Console.WriteLine(year);



// Вид 4 - что-то принимает, что-то возвращает

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "ab");
// System.Console.WriteLine(res);



// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }


