using static System.Console;
Clear();

Write("Введите любое число: ");
int N = int.Parse(ReadLine());
int Z = 2;
WriteLine($"Ниже будут приведены все четные числа до {N}");
while(Z<=N)
{   if(Z%2 == 0)
    {                                
       WriteLine(Z);        
    }
    Z++;
}