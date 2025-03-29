// See https://aka.ms/new-console-template for more information

int num = 10;
double price = 19.95;
string name = "Frank";

// Interpolation
Console.WriteLine($"The number is {num}");
// String concatination
Console.WriteLine("The number is " + num);

// String formatting
Console.WriteLine("The number is {0}, and the price is {1}, and the name is {2}", num, price, name);

// SpecialCharacterInString
string s1 = "this is a \"string\" with \na backslash \\ and a colon: ";
Console.WriteLine(s1);

Console.ReadKey(); 
