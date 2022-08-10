// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)
{
    System.Console.Write(message);                                                  // вывести сообщение
    string readValue = Console.ReadLine();                                          // считывает строку с консоли
    int result = int.Parse(readValue);                                              // преобразует строку в целое число
    return result;                                                                  // возвращает результат
}

int num1 = Prompt("Введите число: ");

if (num1 >= 0)
{
    for (int i = 2; i <= num1; i += 2)
    {
        System.Console.WriteLine(i + " ");
    }
}
else
{
    for (int i = 0; i >= num1; i -= 2)
    {
        System.Console.WriteLine(i + " ");
    }
}