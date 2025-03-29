// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// declare a (string) variable
String myFriendsName;
// assign a value to the myFriendsName variable
myFriendsName = "Yuma";
// use/access the variable
Console.WriteLine(myFriendsName);
// overwriting the variable value
myFriendsName = "Rye";
Console.WriteLine(myFriendsName);
// declare a variable and assign a value to it.
String myFriendsName2 = "Pan";
Console.WriteLine(myFriendsName2);

// implicitely typed variable
var myFavoriteGenre = "LitRPGs";
var myFavoriteNumber = 13;
var yourFavoriteNumber = 14;
var ourNumbersCombined = myFavoriteNumber + yourFavoriteNumber;

// Referency Type
// explicit typed variable
string myName = "Yuma";
// Value Types
int myAge = 25;
double pi = 3.14;
byte age = 255;
short linkdinConnections = 32550;
long photoNumber = 017657723991;
float pi2= 3.14f;

// defining or setting up a variable
string petsName;
// initialize variable
petsName = "Daisy";
Console.WriteLine($"My pet is {petsName}");
// assign a new value
petsName = "Barky";
Console.WriteLine($"My pet is {petsName}");

Console.ReadKey();
