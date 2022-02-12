// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int MaxNumber(int number){
    int max = 0;
    if(number % 10 > number / 10) max = number %10;
    else max = number / 10;
    return max;
}

int number = new Random().Next(10, 99);
Console.WriteLine("Number: " + number);
Console.WriteLine("Max: " + MaxNumber(number));
