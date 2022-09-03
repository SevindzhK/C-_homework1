// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = 0; 
int min = 0;
if (firstNumber > secondNumber) 
{
    Console.Write("max = ");
    Console.WriteLine(firstNumber);
    Console.Write("min = ");
    Console.WriteLine(secondNumber);
}
else 
{
    Console.Write("max = ");
    Console.WriteLine(secondNumber);
    Console.Write("min = ");
    Console.WriteLine(firstNumber);
} 
