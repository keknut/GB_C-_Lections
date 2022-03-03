// Определить количество цифр в числе

int NumberOfDigitsInNumber(int number)
{
    int i = 0;
    while (number >= 1)
    {
        number = number / 10;
        i++;
    }
    return i;
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Number of digits in a {number}: {NumberOfDigitsInNumber(number)}");