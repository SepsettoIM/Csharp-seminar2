// Напишите программу, которая выдает случайное 3-x число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72


Console.Clear();
int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
int firstValue = number / 100; // целочислительное деление
int lastValue = number % 10; // получиил последнюю цифру - остаток от делени на 10
// Console.WriteLine(firstValue);
// Console.WriteLine(secondValue);
// Console.WriteLine($" {number} -> {firstValue}{lastValue}");
Console.WriteLine($" {number} -> {firstValue * 10 + lastValue} ");