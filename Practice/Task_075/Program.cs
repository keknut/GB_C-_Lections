// Есть два массива info и data.
/* Массив data состоит из нулей и единиц хранящий числа
в двоичном представлении. Числа идут друг за другом без разделителей.

Массив info состоит из чисел, которые представляют
колличество бит чисел из массива data.

Составить массив десятичных представлений чисел массива
data с учётом информации из массива info.

Пример:

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
Какие ошибки могут возникнуть при обработке наборов данных? */

int DegreeOfNumber(int numberA, int numberB){
    if(numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};
int[] result = new int[info.GetLength(0)];
int count = 0;
for (int i = 0; i < info.GetLength(0); i++)
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i] += data[j + count] * DegreeOfNumber(2, info[i] - 1 - j);
    }
    count += info[i];
    //Console.WriteLine(result[i]);
}
for (int i = 0; i < result.GetLength(0); i++)
{
    Console.WriteLine(result[i]);
}