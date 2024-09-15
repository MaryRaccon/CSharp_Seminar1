// Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 10;
int secondNumber = number % 10;
int maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
Console.WriteLine(maxNumber);
