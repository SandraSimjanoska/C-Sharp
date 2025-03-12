//Task
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

Console.Write("Enter your birthdate (yyyy-MM-dd): ");
string input = Console.ReadLine();

if (DateTime.TryParse(input, out DateTime birthDate))
{
    int age = AgeCalculator(birthDate);
    Console.WriteLine($"You are {age} years old.");
}
else
{
    Console.WriteLine("Invalid date format. Please enter a valid date.");
}
int AgeCalculator(DateTime birthDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;

    if (birthDate.Date > today.AddYears(-age))
    {
        age--;
    }

    return age;
}