// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);                                                  // вывести сообщение
    string readValue = Console.ReadLine();                                          // считывает строку с консоли
    int result = int.Parse(readValue);                                              // преобразует строку в целое число
    return result;                                                                  // возвращает результат
}

int num1 = Prompt("Введите число: ");

for (int i = num1; i >= 1; i--)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    } 
}