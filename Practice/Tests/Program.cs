/* int NumberDegree(int number, int degree){
    int result = number;
    if (degree == 0) return 1;
    for (int i = 0; i < degree - 1; i++)
    {
        result = result * number;
    }
    return result;
} */

int NumberGroups(int number)
{
    int count = 0;
    while (number / 2 > 0)
    {
        count++;
        number = number / 2;
    }
    count++;
    return count;
}

int number = 20;
int degree = 5;
//Console.WriteLine($"{NumberDegree(number, degree)}");
Console.WriteLine(NumberGroups(number));