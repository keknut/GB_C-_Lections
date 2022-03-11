// По двум заданным числам проверять является ли одно квадратом другого

void squareNumber(int firstNumber, int secondNumber)
{
    bool flag = true;
    if (firstNumber == secondNumber * secondNumber)
    {
        flag = false;
        Console.WriteLine("The first number is the square of the second.");
    }
    if (firstNumber * firstNumber == secondNumber)
    {
        flag = false;
        Console.WriteLine("The second number is the square of the first.");
    }
    if(flag) Console.WriteLine("Neither number is the square of the other");
}

Console.Write("Input first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = int.Parse(Console.ReadLine());

squareNumber(firstNumber, secondNumber);