// Задайте значения M и N. Напишите программу,
// которая найдёт сумму элементов в промежутке от M до N.
// M = 1; N = 4 -> 10
// M = 4; N = 8. -> 30

int SumNumbers(int numberM, int numberN)
{
    if (numberN < numberM) return 0;
    return SumNumbers(numberM, numberN - 1) + numberN;
}

Console.Write("Inpunt M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Inpunt N: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"Summ: {SumNumbers(numberM, numberN)}");