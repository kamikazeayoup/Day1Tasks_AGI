using Checking;

Console.WriteLine("Enter the Number");
int input = Convert.ToInt32(Console.ReadLine());
string solution = "";
solution = (CheckNumbers.EvenOdd(input)) ? "Even" : "Odd" ;
Console.WriteLine(solution);    