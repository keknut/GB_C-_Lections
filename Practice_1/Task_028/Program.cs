// Подсчитать сумму цифр в числе

int sumDigitsNumber(int number)
{
    int result = 0;
    while (number >= 1)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}


Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum of the digits in a {number}: {sumDigitsNumber(number)}");