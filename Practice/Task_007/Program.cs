// Показать числа от -N до N

Console.Write("Input first number: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int numberTwo = int.Parse(Console.ReadLine());

if(numberTwo < numberOne){
    int temporary = numberOne;
    numberOne = numberTwo;
    numberTwo = temporary;
}

while(numberOne <= numberTwo){
    Console.Write($"{numberOne} ");
    numberOne++;
}