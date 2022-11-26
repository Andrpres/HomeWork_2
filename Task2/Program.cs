/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) {
    Console.WriteLine("третьей цифры нет");
} else {
    int digitCount = (int)Math.Log10(number) + 1;
    int digitDivision = 1;
    for (int i = 0; i < (digitCount - 3); i++)
    {
        digitDivision = digitDivision * 10;
    }
    int digitOne = (number / digitDivision) % 10;
    Console.WriteLine($"{digitOne}");
}