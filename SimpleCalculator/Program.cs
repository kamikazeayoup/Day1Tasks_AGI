using SimpleCalculator;
Console.WriteLine("Enter first number");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum = {Calculator.Sum(first, second)}");
Console.WriteLine($"Subtract = {Calculator.Subtract(first, second)}");
Console.WriteLine($"Multiplie = {Calculator.Multiplie(first, second)}");
try
{
    Console.WriteLine($"Division = {Calculator.Division(first, second)}");

}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}