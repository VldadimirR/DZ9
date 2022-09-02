/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.(необязательная)

m = 2, n = 3 -> A(m,n) = 29
A  | n=0     1     2     3     4     5     6     7     8     9    10
-----+-----------------------------------------------------------------
 m=0 |   1     2     3     4     5     6     7     8     9    10    11
   1 |   2     3     4     5     6     7     8     9    10    11    12
   2 |   3     5     7     9    11    13    15    17    19    21    23
   3 |   5    13    29    61   125   253   509  1021  2045  4093  8189
   4 |  13 65533 
В примере задачи ошибка должно получаться 9
*/
Console.Clear();
Console.WriteLine($"Введите  число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите  число:");
int numberB = Convert.ToInt32(Console.ReadLine());

int Ackerman(int numberA, int numberB)
{
    if (numberA == 0)
    {
        return numberB + 1;
    }
    else
      if (numberB == 0)
    {
        return Ackerman(numberA - 1, 1);
    }
    else
    {
        return Ackerman(numberA - 1, Ackerman(numberA, numberB - 1));
    }
}
Console.Write(Ackerman(numberA,numberB));
