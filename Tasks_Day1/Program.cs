// See https://aka.ms/new-console-template for more information
using System.Drawing;
using Tasks_Day1;
Console.WriteLine("Enter The Length");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The Width");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(RectangleClass.GetArea(length, width));