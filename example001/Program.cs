using static System.Console;
Clear();

Write("Введите первое число: ");
int number = int.Parse(ReadLine());
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine());

if (number>number2)
{
    WriteLine($"Число {number} является максимальным, а число {number2} минимальным.");
}
else
{
    WriteLine($"Число {number} является минимальным, а число {number2} максимальным.");
}
