// See https://aka.ms/new-console-template for more information

// implicit conversion
int myInt1 = 1323450983;
double myDouble1 = myInt1;

long myLong1 = myInt1;
// ❌ myInt1 = myLong;
myLong1 = 132345098312389013;

float myFloat1 = 123.123f;
myDouble1 = myFloat1;

// explicit conversion (casting) we are casting from one type to another type
long myLong2 = 1323450;
int myInt2 = (int)myLong2; // explicit conversion
myInt2 = (int)myDouble1; // explicit conversion

float myFloat2 = 123.123f;
double myDouble2 = 13.2123123123;
myFloat2 = (float)myDouble2; // explicit conversion
Console.WriteLine($"myFloat2: {myFloat2}");

int myInt3;
double myDouble3 = 13.5;
myInt3 = (int)myDouble3; // explicit conversion
Console.WriteLine($"myInt3: {myInt3}");

// Conversion Helpers Parse and Convert
string numberString = "123";
int result = int.Parse( numberString );

string myBoolString = "true";
bool myBool = Convert.ToBoolean( myBoolString );
Console.WriteLine("myBool is " + myBool);
Convert.ToString(myBool);

//string myBoolString2 = "123";
// ❌ bool myBool2 = Convert.ToBoolean(myBoolString2);
//Console.WriteLine("myBool is " + myBool2);

Console.ReadKey();
