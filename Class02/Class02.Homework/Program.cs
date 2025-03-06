#region Task1 ConsoleApp: RealCalculator
//Create new console application called“RealCalculator” that takes two numbers
//from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

using System.Diagnostics.Metrics;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

Console.Write("Enter the first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Enter the Operation (+, -, *, /): ");
char charOperation = Console.ReadLine()[0];

double result = 0;
bool isValidCharOperation = true;

switch (charOperation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
            result = num1 / num2;
        else
        {
            Console.WriteLine("Error: You can not devide by 0.");
            isValidCharOperation = false;
        }
        break;
    default:
        Console.WriteLine("Error! Please enter +, -, *, or /.");
        isValidCharOperation = false;
        break;
}

if (isValidCharOperation)
    Console.WriteLine("The result is: " + result);
#endregion
#region Task2 ConsoleApp: AverageNumber
//Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.Write("Enter the First number: ");
double number1 = double.Parse(Console.ReadLine());

Console.Write("Enter the Second number: ");
double number2 = double.Parse(Console.ReadLine());

Console.Write("Enter the third number: ");
double number3 = double.Parse(Console.ReadLine());

Console.Write("Enter the fourth number: ");
double number4 = double.Parse(Console.ReadLine());

double average = (number1 + number2 + number3 + number4) / 4;

Console.WriteLine($"The average of {number1}, {number2}, {number3} and {number4} is: {(int)average}");
#endregion
#region Task3 ConsoleApp: SwapNumbers
//Create new console application called “SwapNumbers”. Input 2 numbers from the console and then
//swap the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

int temporaryHolder = firstNumber;
firstNumber = secondNumber;
secondNumber = temporaryHolder;

Console.WriteLine("After swapping:");
Console.WriteLine("First number: " + firstNumber);
Console.WriteLine("Second number: " + secondNumber);
#endregion