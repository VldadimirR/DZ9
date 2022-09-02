/*
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
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
        return $"{numberB } " + Number(numberA, numberB  - 1);
    }
    else
    {
        return $"{numberA}";
    }
}
Console.WriteLine(Number(numberA, numberB));
