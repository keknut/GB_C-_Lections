// Написать программу возведения числа А в целую стень B

int DegreeOfNumber(int numberA, int numberB){
    if(numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}

Console.Write("Inpunt number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Inpunt number B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Degree of {numberA} in {numberB}: {DegreeOfNumber(numberA, numberB)}");