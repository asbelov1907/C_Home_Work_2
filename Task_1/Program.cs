// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number_do = int.Parse(Console.ReadLine());

if (number_do >= 100 && number_do <= 999)
{
    string number = number_do.ToString();
    Console.WriteLine("Вторая цифра числа " + number_do + " равна " + number[1]);
}
else 
    Console.WriteLine("Число " + number_do + " не является трехзначным");

