// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int Summ(int firstNumber, int secondNumber, int numberN){
    if(numberN == 1) return firstNumber;
    if(numberN == 2) return secondNumber;
    return Summ(firstNumber, secondNumber, numberN - 1) + Summ(firstNumber, secondNumber, numberN - 2);
}

Console.Write("Input first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Enter number of numbers : ");
int numberN = int.Parse(Console.ReadLine());


for (int i = 1; i <= numberN; i++)
{
    Console.Write($"{Summ(firstNumber, secondNumber, i)} ");   
}