// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);                                                  // вывести сообщение
    string readValue = Console.ReadLine();                                          // считывает строку с консоли
    int result = int.Parse(readValue);                                              // преобразует строку в целое число
    return result;                                                                  // возвращает результат
}

int max;
int min;

int num1 = Prompt("Введите первое число: ");
int num2 = Prompt("Введите второе число: ");
int num3 = Prompt("Введите третье число: ");

if (num1 >= num2 && num1 >= num3) 
{
    max = num1;
} 
else if (num2 >= num1 && num2 >= num3) 
{
    max = num2;
} 
else if (num3 >= num1 && num3 >= num2) 
{
    max = num3;
}
// int maximal = Math.Max(Math.Max(num1, num2), num3); // можно ещё так

if (num1 <= num2 && num1 <= num3) 
{
    min = num1;
} 
else if (num2 <= num1 && num2 <= num3) 
{
    min = num2;
} 
else if (num3 <= num1 && num3 <= num2) 
{
    min = num3;
}
// int minimal = Math.Min(Math.Min(num1, num2), num3); // можно ещё так