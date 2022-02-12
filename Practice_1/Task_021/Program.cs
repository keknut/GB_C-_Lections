// Программа проверяет пятизначное число на палиндромом.

void fiveDigitPalindrome(int number)
{
    if (number < 10000 || number > 99999) //если число не пятизначное, выводим сообщение
    {
        Console.WriteLine("Number is not five digit!");
    }
    else
    {  //если первая цифра равна последней и если вторая цифра равна четвёртой
        if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
        {
            Console.WriteLine("The number is a palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not a palindrome ");
        }
    }
}
Console.Write("Input a five-digit number: ");
int number = int.Parse(Console.ReadLine());

fiveDigitPalindrome(number);