/*
Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/
Console.Clear();
Console.WriteLine ($"Введите  число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Введите  число:");
int numberB = Convert.ToInt32(Console.ReadLine());

string Number(int numberA , int numberB)
{
    if (numberA < numberB)
    {
        return $"{numberA } " + Number(numberA  + 1, numberB);
    }
    else
    {
        return $"{numberB}";
    }
}
Console.WriteLine(Number(numberA, numberB));
