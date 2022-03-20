// Есть число N. Скольно групп M, можно получить при
/*разбиении всех чисел на группы, так чтобы в одной
группе все числа были взаимно просты.
Например для N = 50, M получается 6

Одно из решений :

Группа 1: 1 
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 7 16 24 36 40 
Группа 6: 5 32 48
Ещё одно решение:

Группа 1: 1 
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 16 24 36 40 
Группа 6: 32 48
Задача: найти M при заданном N и получить одно
из разбиений на группы N ≤ 10²⁰*/

// Метод возводит число в степень
int NumberDegree(int number, int degree)
{
    int result = number;
    if (degree == 0)
        return 1;
    for (int i = 0; i < degree - 1; i++)
    {
        result = result * number;
    }
    return result;
}

Console.Write("Input N: ");
int numberN = int.Parse(Console.ReadLine());
int countGroups = 1;
int j = 1;
bool flag = true;

while (flag)
{
    Console.Write($"Group {countGroups}: ");
    while (j <= NumberDegree(2, countGroups) - 1)
    {
        Console.Write($"{j} ");
        j++;
        if(j > numberN) break;
    }
    Console.WriteLine();
    if(j > numberN) flag = false;
    countGroups++;
}