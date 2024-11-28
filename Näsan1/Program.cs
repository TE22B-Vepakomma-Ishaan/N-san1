using System.Runtime.ConstrainedExecution;

if (6 >= 3)
{
    System.Console.WriteLine("Hello World!");
}

// System.Console.WriteLine("Write your username:");
// string u = Console.ReadLine();
// System.Console.WriteLine("Write your password:");
// string p = Console.ReadLine();


// for (int i = 0; i < 32; i++)
// {
//     System.Console.WriteLine("hello world!");
// }

// while(u != "kalleanka" || p != "12345")
// {
//     System.Console.WriteLine("Wrong username or password.");
//     System.Console.WriteLine("Write your username:");
//     u = Console.ReadLine();
//     System.Console.WriteLine("Write your password:");
//     p = Console.ReadLine();
// }

// if(u == "kallenka" && p=="12345")
// {
//     System.Console.WriteLine("Welcome!");
// }


// for (int i = 0; i < 5; i++)
// {
//     string s = Console.ReadLine();
//     int d; 
//     int.TryParse(s, out d);
//     if (d > 5)
//     {
//         System.Console.WriteLine("higher than 5!");
//     }
// }



Random random = new();

int ans = random.Next(1, 100);

string guess;
int num = 0;
bool isNum;

while(num != ans)
{
    System.Console.WriteLine("guess a number:");
    guess = Console.ReadLine();
    isNum = int.TryParse(guess, out num);

    if(isNum == false)
    {       
            System.Console.WriteLine("not a number. guess again:");
            guess = Console.ReadLine();
            isNum = int.TryParse(guess, out num);
    }

    if(num > ans)
    {
        System.Console.WriteLine("lower");
    }
    if (num < ans)
    {
        System.Console.WriteLine("higher");
    }
}

if(num == ans)
{
    System.Console.WriteLine("you guessed right!");
}



Console.ReadKey();
