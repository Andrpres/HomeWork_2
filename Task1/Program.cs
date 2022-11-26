/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999) {
    Console.WriteLine("Введите именно трехзначное число!");
} else {
    int digitOne = (number % 100) / 10;
    Console.WriteLine($"Вторая цифра этого числа: {digitOne}");
}