// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Input number 1: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Input number 2: ");
int number_2 = int.Parse(Console.ReadLine());
if (number_1 == number_2 * number_2){
    Console.WriteLine("Yes!");
}else{
    Console.WriteLine("No(");
}
