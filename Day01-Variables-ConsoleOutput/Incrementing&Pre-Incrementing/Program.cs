// See https://aka.ms/new-console-template for more information

int num = 0;
Console.WriteLine($"Num is {num}"); // 【num = 0】
// incrementing of int
num++; // 0 = 0 + 1 = 1
Console.WriteLine($"Num is {num}"); // 【num = 1】

// Pre-incrementing
Console.WriteLine("Num is {0}", ++num); // 1 = 1 + 1 = 2, 【num = 2】
Console.WriteLine("Num is {0}", num++); // 【num = 2】, 2 = 2 + 1 = 3
Console.WriteLine("Num is {0}", num); // 【num = 3】

// decrementing
num--; // 3 = 3 - 1 = 2
Console.WriteLine("Num is {0}", num); // 【num = 2】
Console.WriteLine("Num is {0}", --num); // 2 = 2 - 1 = 1, 【num = 1】
Console.WriteLine("Num is {0}", num--); // 【num = 1】, 1 = 1 - 1 = 0
Console.WriteLine("Num is {0}", num); // 【num = 0】

num = 1;
num += 30;
Console.WriteLine("Num is {0}", num);
num -= 10;
Console.WriteLine("Num is {0}", num);
num *= 10;
Console.WriteLine("Num is {0}", num);
num /= 21;
Console.WriteLine("Num is {0}", num);

int num1 = 10;
int num2 = 3;
// Modulo Operator
int result = num1 % num2;
Console.WriteLine(result); // 10 ÷ 3 = 3 remainder 1

Console.ReadKey();
