using static System.Console;
Clear();

Write("Введите любое число: ");
int number = int.Parse(ReadLine());

int x = number % 2;

if (x == 0)
    Write($"Число {number} является четным");
else
    Write($"Число {number} не является четным");