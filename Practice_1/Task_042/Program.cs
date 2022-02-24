// Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("Input numbers: ");

bool success = true; // Флаг нужен для того, чтобы если пользователь введёт не число, выходим из цикла.
int count = 0; // Счётчик чисел больше нуля.
string value = null; // В эту строку мы помещаем то, что вводит пользователь.
int number = 0; // Сюда мы парсим наше число из строки в целочисиленное.
while(success){ // Если введённая строка парсится успешно в число, мы в цикле.
    value = Console.ReadLine(); // Считываем число.
    success = int.TryParse(value, out number); // Присваиваем булевой переменной true, если строка парсится в число.
    if(success && number > 0){ // Если строка число И это число больше нуля, увеличиваем счётчик. 
        count++;
    }
}
Console.WriteLine($"Numbers greater than zero {count}");