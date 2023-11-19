// Задача 64
// Задайте значения M и N.
// Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

static void PrintEvenNums(int M, int N)
{
    int divider = 2;

    if (M % divider == 0)
    {
        if (M + divider <= N) //рекуррентный случай
        {
            Console.Write($"{M}, ");
            PrintEvenNums(M + divider, N);
        }
        else //крайний случай
        {
            Console.Write($"{M}\n");
        }
    }
    else
    {
        PrintEvenNums(M + 1, N);
    }
}

Console.WriteLine("Задача 64");
PrintEvenNums(4, 8);



// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N 
// с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static int SumNums(int M, int N)
{
    int sum = M;

    if (M < N)
    {
        sum += SumNums(M + 1, N);
    }

    return sum;
}

Console.WriteLine("Задача 66");
Console.WriteLine(SumNums(4, 8));



// Задача 68
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

static int Ackermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if (m == 0)
        {
            return Ackermann(n - 1, 1);
        }
        else
        {
            return Ackermann(n - 1, Ackermann(n, m - 1));
        }
    }
}

Console.WriteLine("Задача 68");
Console.WriteLine(Ackermann(3, 2));