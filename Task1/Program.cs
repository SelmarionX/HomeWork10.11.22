// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"
Console.Clear();

int N = 8;

EvenNumbers(N);

int EvenNumbers(int n)
{
    if (n <= 1) return n;
    else
    {
        if (n % 2 == 0)
        {
            Console.Write($" {n}");
            EvenNumbers(n - 2);
        }
        else
        {
            n--;
            Console.Write($" {n}");
            EvenNumbers(n - 2);
        }
        return n;
    }
}

