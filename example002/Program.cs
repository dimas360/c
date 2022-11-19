using static System.Console;
Clear();

Write("Введите первое число: ");
int number = int.Parse(ReadLine());
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine());
Write("Введите третье число: ");
int number3 = int.Parse(ReadLine());

if(number > number2 && number >number3)
    WriteLine($"Число {number} является максимальным.");
if(number2>number && number2>number3)
    WriteLine($"Число {number2} является максимальным");
else
    WriteLine($"Число {number3} является максимальным");