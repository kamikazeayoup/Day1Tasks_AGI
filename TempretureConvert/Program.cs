// See https://aka.ms/new-console-template for more information
using TempretureConvert;
Console.WriteLine("Enter The Celesuis Degree");
double celesuis = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" Fehrenhiet = {TempretureConverts.CelsiusToFahrenheit(celesuis)}");