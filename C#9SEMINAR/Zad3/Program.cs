/*
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
Console.Clear();
Console.WriteLine($"Введите  число:");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    if (number == 0)
    {
        return 0;
    }
    else
    {
        return number % 10 + Sum(number / 10);
    }
}
Console.WriteLine(Sum(number));
