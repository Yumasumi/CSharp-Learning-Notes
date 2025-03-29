// See https://aka.ms/new-console-template for more information

// datatype variableName = initial value;
using System.Globalization;

int myNumber1 = 0;
int myNumber2 = 0;

// Prints out whatever is in side of ()
Console.WriteLine("Enter a whole number!");

// takes the user input and stores it
// Variable with the name "userInput" and the data type "string"
// strings are used for text
string userInput = Console.ReadLine();
// myNumber = int.Parse(Console.ReadLine());
myNumber1 = int.Parse(userInput);

Console.WriteLine("Enter a whole number!");
userInput = Console.ReadLine();
myNumber2 = int.Parse(userInput);


int sum1 = myNumber1 + myNumber2;
// we are adding to strings together and writing them onto the console
// string concatination
Console.WriteLine("The result of " + myNumber1 + " and " + myNumber2 + " is " + sum1);

// string interpolation
Console.WriteLine($"The result of {myNumber1} and {myNumber2} is {sum1}");

Console.WriteLine("----------");
double myNumber3 = 0.0;
double myNumber4 = 0.0;
Console.WriteLine("Enter a whole number!");
userInput = Console.ReadLine();
myNumber3 = double.Parse(userInput);
Console.WriteLine("Enter a whole number!");
userInput = Console.ReadLine();
myNumber4 = double.Parse(userInput);
double sum2 = myNumber3 + myNumber4;
// 四捨五入到小數點後兩位
sum2 = Math.Round(sum2, 2); 
Console.WriteLine($"The result of {myNumber3} and {myNumber4} is {sum2}");

// myNumber = double.Parse(userInput, CultureInfo.InvariantCulture);
Console.WriteLine(myNumber1.ToString(CultureInfo.InvariantCulture));

Console.ReadKey();
