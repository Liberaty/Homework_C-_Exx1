// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int Prompt(string message)
{
    System.Console.Write(message);                                                  // вывести сообщение
    string readValue = Console.ReadLine();                                          // считывает строку с консоли
    int result = int.Parse(readValue);                                              // преобразует строку в целое число
    return result;                                                                  // возвращает результат
}

int num1 = Prompt("Введите первое число: ");
int num2 = Prompt("Введите второе число: ");

if (num1 > num2) 
{
    System.Console.WriteLine($"Число {num1} больше, а число {num2} меньше");
} 
else if (num1 < num2) 
{
    System.Console.WriteLine($"Число {num2} больше, а число {num1} меньше");
}