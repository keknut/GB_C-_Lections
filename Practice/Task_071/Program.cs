// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 3 -> A(m,n) = 29

int Akkerman(int numberM, int numberN){
    if(numberM == 0){
        return numberN + 1;
    }else{
        if((numberM != 0) && (numberN == 0)){
            return Akkerman(numberM - 1, 1);
        }else{
            return Akkerman(numberM - 1, Akkerman(numberM, numberN-1));
        }
    }
}

Console.Write("Inpunt M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Inpunt N: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"Akkerman({numberM},{numberN}): {Akkerman(numberM, numberN)}");