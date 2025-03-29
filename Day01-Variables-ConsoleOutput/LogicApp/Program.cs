// See https://aka.ms/new-console-template for more information

bool isRainy = false;
bool hasUmbrella = true;

// Logical Opreators
// AND &&
// OR ||
// NOT !

// Variables of OR statements
// true || true -> true
// true || false -> true
// false || true -> true
// false || false -> false

// Variables of AND operator/statements
// true && true -> true
// true && false -> false
// false && true -> false
// false && false -> false

if (isRainy)
{
    Console.WriteLine("It's rainy");
}

if (isRainy && hasUmbrella)
{
    Console.WriteLine("I'm protected against rain");
}

if (isRainy || hasUmbrella)
{
    Console.WriteLine("I'm not getting wet!");
}

if (!isRainy || hasUmbrella)
{
    Console.WriteLine("I'm not getting wet!");
}

Console.WriteLine("Ay OK!");

Console.WriteLine("----------");

int num1 = 5;
int num2 = 6;

// relational operator  <  <=  >  >=

bool isHigher = num1 < num2;
bool isGreater = num1 > num2;

Console.WriteLine("How old are you? Write a whole number");
int age = int.Parse(Console.ReadLine());
bool isWithParents = false;

if (age >= 18)
{
    Console.WriteLine("Go party in the club!");
}
else if (age >= 13)
{
    Console.WriteLine("Are you with your parents? Answer with y or n");
    string isWithParentsString = Console.ReadLine();
    if (isWithParentsString == "y")
    {
        Console.WriteLine("Go party in the club with your parents!");
    }
    else
    {
        Console.WriteLine("No party for you today");
    }
}
else
{
    Console.WriteLine("Go party in Kindergarten!");
}

Console.WriteLine("----------");

int num3 = 0;
int num4 = 0;

bool isEqual = num3 == num4;
bool isNotEqual = num3 != num4;

Console.WriteLine("Please enter a whole number");

if (num3 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");

    Console.WriteLine("Please enter your age");
    int yourAge = int.Parse(Console.ReadLine());
    if (yourAge >= 18)
    {
        Console.WriteLine("Please enter your address, so that we can send you the price!");
        string address = Console.ReadLine();    
    }
    else
    {
        Console.WriteLine("Sorry, you can't get your price due to your age!");
    }
}
else
{
    Console.WriteLine("Numbers aren't equal");
}

Console.WriteLine("----------");

int month = 2;
string monthName;

if (month == 1)
    Console.WriteLine(monthName = "January");
else if (month == 2)
    Console.WriteLine(monthName = "February");
else if (month == 3)
    Console.WriteLine(monthName = "March");
else
    Console.WriteLine(monthName = "Unknown");

Console.WriteLine("----------");

string monthString = "Apr";
switch (monthString)
{ 
    case "Jan":
        Console.WriteLine(monthName = "January");
        break;
    case "Feb":
        Console.WriteLine(monthName = "February");
        break;
    case "Mar":
        Console.WriteLine(monthName = "March");
        break;
    case "Apr":
        Console.WriteLine(monthName = "April");
        break;
    default:
        Console.WriteLine(monthName = "Unknown");
        break;
}

Console.WriteLine($"The month is {monthName}");

Console.ReadKey();
