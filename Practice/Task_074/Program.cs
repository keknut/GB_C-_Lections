// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв,
//которые можно построить из букв этого алфавита

string[] Words(string alphabet, int numberN){
    if(numberN == 0){
        return new string[]{""};
    }
    string[] wordsSave = Words(alphabet, numberN - 1);
    string[] result = new string[wordsSave.GetLength(0) * 4];
    int k = 0;
    for (int i = 0; i < wordsSave.GetLength(0); i++)
    {
        for (int j = 0; j < alphabet.Length; j++)
        {
            result[k] = wordsSave[i] + alphabet[j];
            k++;
        }
    }
    return result;
}

string alphabet = "аисв";
Console.Write("Input N: ");
int numberN = int.Parse(Console.ReadLine());
string[] res = Words(alphabet, numberN);
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);    
}

