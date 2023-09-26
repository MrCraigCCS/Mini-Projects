// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please give me the first number.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Next, give me the second number.");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You entered {num1} and {num2}. \nNow please enter a math symbol.");

string symbol = Console.ReadLine();

int result = 0;

if (symbol == "+")
{
    result = num1 + num2;
}
else if (symbol == "-")
{
    result += num1 - num2;
}
else if (symbol == "*")
{
    result = num1 * num2;
}
else if (symbol == "/")
{
    result = num1 / num2; 
}
else
{
    Console.WriteLine("Incorrect symbol. Please try agin");
}

Console.WriteLine($"The answer is {result}. Have a nice day!");