// Показать натуральные числа от N до 1, N задано.

void PrintNumber(int number)
{
    if (number < 1) return;
    Console.Write($"{number} ");
    PrintNumber(number - 1);
}

Console.Write("Inpunt N: ");
int number = int.Parse(Console.ReadLine());
PrintNumber(number);