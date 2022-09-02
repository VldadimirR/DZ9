/*
Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 25 мин
*/
Console.Clear();
Console.WriteLine($"Введите  число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите  число:");
int numberA = Convert.ToInt32(Console.ReadLine());

int Degree(int number, int numberA)
{
    {
        return numberA == 0 ? 1 : Degree(number, numberA - 1) * number;
    }
}
Console.WriteLine(Degree(number, numberA));
