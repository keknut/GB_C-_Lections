// Показать натуральные числа от M до N, N и M заданы

void PrintNumber(int numberM, int numberN)
{
    if (numberN < numberM) return;
    PrintNumber(numberM, numberN - 1);
    Console.Write($"{numberN} ");
}

Console.Write("Inpunt number M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Inpunt number N: ");
int numberN = int.Parse(Console.ReadLine());
PrintNumber(numberM, numberN);