// Показать числа Фибоначчи

void Fibonacci(int limit){
    int numberZero = 0;
    int numberOne = 1;
    int temp = 0;
    Console.Write($"{numberZero} {numberOne} ");
    for(int i = 0; i <= limit; i++){
        temp = numberZero + numberOne;
        Console.Write($"{temp} ");
        numberZero = numberOne;
        numberOne = temp;
    }
}

Console.Write("Input upper limit: ");
int limit = int.Parse(Console.ReadLine());

Fibonacci(limit);