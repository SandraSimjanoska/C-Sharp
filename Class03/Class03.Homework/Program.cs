#region Task 1
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input,
//find and print the sum of the even numbers from the array:
//Test Data:
//Enter integer no.1:
//4
//Enter integer no.2:
//3
//Enter integer no.3:
//7
//Enter integer no.4:
//3
//Enter integer no.5:
//2
//Enter integer no.6:
//8
//Expected Output:
//The result is: 14

Console.WriteLine("Task 1 - SumOfEven");
int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter integer no.{i + 1}: ");
    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
    {
        Console.Write("Error! Please enter a valid integer: ");
    }
}

foreach (int num in numbers)
{
    if (num % 2 == 0)
    {
        sum += num;
    }
}

Console.WriteLine($"The result is: {sum}");
#endregion
#region Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

Console.WriteLine("Task 2 - StudentGroup");
string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Sandra", "Angel", "Ana", "Simona", "Marija" };

Console.Write("Enter student group (1 or 2): ");
int selectedGroup;

if (int.TryParse(Console.ReadLine(), out selectedGroup) && (selectedGroup == 1 || selectedGroup == 2))
{
    if (selectedGroup == 1)
    {
        Console.WriteLine("The students in Group G1 are:");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (selectedGroup == 2)
    {
        Console.WriteLine("The students in Group G2 are:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
}
else
{
    Console.WriteLine("Error! Invalid group number, please enter 1 or 2.");
}
#endregion
#region Task 3
//Create an array with names
//Give an option to the user to enter a name from the keyboard
//After entering the name put it in the array
//Ask the user if they want to enter another name(Y / N)
//Do the same process over and over until the user enters N
//Print all the names after user enters N

Console.WriteLine("Task 3 - Array with names");
string[] nameList = new string[0];
string userResponse;

while (true)
{
    Console.Write("Enter a name: ");
    string enteredName = Console.ReadLine();

    Array.Resize(ref nameList, nameList.Length + 1);
    nameList[nameList.Length - 1] = enteredName;

    Console.Write("Do you want to enter another name? Please enter (Y for Yes/N for No): ");
    userResponse = Console.ReadLine().ToUpper();

    while (userResponse != "Y" && userResponse != "N")
    {
        Console.WriteLine("Invalid input! Please enter 'Y' for Yes or 'N' for No.");
        Console.Write("Do you want to enter another name? Please enter (Y for Yes/N for No): ");
        userResponse = Console.ReadLine().ToUpper();
    }

    if (userResponse == "N")
        break;
}

Console.WriteLine("Entered names:");
foreach (string name in nameList)
{
    Console.WriteLine(name);
}
#endregion