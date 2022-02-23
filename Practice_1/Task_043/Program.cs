// Написать программу преобразования десятичного числа в двоичное

string DecimalToBinary(int number)
{
    string result = "";
    while (number > 0) { 
        if(number % 2 == 0){
            result = "0" + result; 
        } else{
            result = "1" + result;
        }
        number = number / 2;
    }
    return result;
}

Console.Write("Input decimal number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Decimal to binary: {DecimalToBinary(number)}");

