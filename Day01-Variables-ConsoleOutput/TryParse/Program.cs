// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number");
string inputString1 = Console.ReadLine();
int num1 = int.Parse(inputString1);
num1++;
Console.WriteLine("User entered number +1 " + num1);

Console.WriteLine("----------");

// creating an insance of the Random Class
Random random = new Random();
// this will give us a random number between 1 and 10
int randomNumber = random.Next(1, 11); // Next 是 method，括號是想要的數字範圍
Console.WriteLine(randomNumber); // 可以看到 random 的數字是幾

Console.WriteLine("Guess the number");

string inputString2 = Console.ReadLine();
int num2 = 0;
bool isNumber1 = int.TryParse(inputString2, out num2);

if (isNumber1)
{
    if (num2 == randomNumber)
    {
    Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong, try again!");
    }
}
else
{
    Console.WriteLine("Haha you troll. You should've entered a number.");
}


Console.WriteLine("----------");

// 如果用戶輸入的不是數字，就會報錯
// TryParse 是一種 method，他允許我們解決用戶輸入的不是數字的問題
// TryParse 返回的是 bool，表示轉換是否成功
// 如果轉換成功，就把 inputString3 賦值給 num3 這個參數
Console.WriteLine("Give me a number");
string inputString3 = Console.ReadLine();
int num3; // 沒有賦值的 int 預設是 0
int.TryParse(inputString3, out num3);
num3++; // 用戶輸入的不是 int，沒有賦值的 int 預設 0，故 0 = 0 + 1 = 1
Console.WriteLine("User entered number +1 " + num3);

bool isNumber2 = int.TryParse(inputString2, out num3);
if (isNumber2)
{
    Console.WriteLine("Well done, you entered a number.");
}
else
{
    Console.WriteLine("Haha you troll. You should've entered a number.");
}

Console.ReadKey();


