// Возведите число А в натуральную степень B используя цикл

int numberOfPower(int number, int degree)
{
    int degreeNumber = 1;
    for (int i = 1; i <= degree; i++)
    {
        degreeNumber = degreeNumber * number;
    }
    return degreeNumber;
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Input degree: ");
int degree = int.Parse(Console.ReadLine());

Console.WriteLine($"{number}^{degree}: {numberOfPower(number,degree)}");