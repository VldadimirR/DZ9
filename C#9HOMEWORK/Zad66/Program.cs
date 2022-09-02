/*
: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/
Console.Clear();
Console.WriteLine($"Введите  число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите  число:");
int numberB = Convert.ToInt32(Console.ReadLine());

int Sum(int numberA, int numberB)
{
    if (numberA % 2 != 0)
    {
        numberA++;
    }
    if (numberA <= numberB)
    {
        return numberA + Sum(numberA + 2, numberB);
    }
    else
    {
        return 0;
    }
}
Console.WriteLine(Sum(numberA, numberB));
