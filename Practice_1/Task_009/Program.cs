// Показать последнюю цифру трёхзначного числа.

int returnLastNumber(int number)
{
    return number % 10;
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Last number: " + returnLastNumber(number));