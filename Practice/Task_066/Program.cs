// Показать натуральные числа от 1 до N, N задано

void PrintNumber(int number)
{
    if (number < 1) return;
    PrintNumber(number - 1);
    Console.Write($"{number} ");
}

Console.Write("Inpunt number: ");
int number = int.Parse(Console.ReadLine());
PrintNumber(number);