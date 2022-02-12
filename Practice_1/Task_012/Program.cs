// Удалить вторую цифру трёхзначного числа

int DeleteSecondDigitInNimber(int number){
    int thirdDigit = number % 10;
    number = (number / 100) * 10 + thirdDigit;
    return number;
}

Console.Write("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Result: " + DeleteSecondDigitInNimber(number));
