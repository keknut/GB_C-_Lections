// Даны два числа. Показать большее и меньшее число

Console.Write("Input first number: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int number_2 = int.Parse(Console.ReadLine());
if(number_1 > number_2){
    Console.WriteLine("Max: " + number_1);
    Console.WriteLine("Min: " + number_2);
}
if(number_1 < number_2){
    Console.WriteLine("Max: " + number_2);
    Console.WriteLine("Min: " + number_1);
}
if (number_1 == number_2){
    Console.WriteLine("The numbers are equal");
}