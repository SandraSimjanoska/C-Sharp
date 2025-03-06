#region Exercise1
//Solve the following problem. On one tree there are 12
//branches with n apples on them. One basket can hold m
//apples. If a user enters number of trees find out how
//many baskets does it take to collect all the apples from
//the trees?
//● n = 8
//● m = 5
//Result = ?

int n = 8;
int m = 5;
int branchesPerTree = 12;

Console.WriteLine("Enter the number of trees: ");
int numberOfTrees = int.Parse(Console.ReadLine());

int totalApples = numberOfTrees * branchesPerTree * n;
int basketsNeeded = (totalApples + m - 1) / m;

Console.WriteLine("Total baskets needed: " + basketsNeeded);
#endregion
#region Exercise2
//Create two variables and initialize them
//● Write code that can test which number is larger
//● Write code that can test the numbers whether they are
//even or odd
//Output:
//● Write in the console: The larger number from the two is
//#Number#
//● After that write: And the number is even/odd

int num1 = 10;
int num2 = 20;

int largerNumber = (num1 > num2) ? num1 : num2;

string evenOrOdd = (largerNumber % 2 == 0) ? "even" : "odd";

Console.WriteLine("The larger number from the two is " + largerNumber);
Console.WriteLine("And the number is " + evenOrOdd);
#endregion
#region Exercise3
//Ask the user to enter a number from 1 to 3
//● If the user enters “1” write “You got a new car!”
//● If the user enters “2” write “You got a new plane!”
//● If the user enter “3” write “You got a new bike!”
//● If the user enters a wrong number or character write an
//error message in the console

Console.Write("Enter a number from 1 to 3: ");
string userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        Console.WriteLine("You got a new car!");
        break;
    case "2":
        Console.WriteLine("You got a new plane!");
        break;
    case "3":
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Error: Invalid input. Please enter a number from 1 to 3.");
        break;
}
#endregion