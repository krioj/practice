using System.Diagnostics.CodeAnalysis;
string exid;
do
{
    Console.WriteLine("write 2 numbers");

    float Namber = float.Parse(Console.ReadLine());
    float Namber2 = float.Parse(Console.ReadLine());
    float resalt = 0;
    Console.WriteLine("what do you want to do? (/, *, +, -, %)");

    switch (Console.ReadLine())
    {
        case "/":
            resalt = Namber / Namber2;
            break;
        case "*":
            resalt = Namber * Namber2;
            break;
        case "+":
            resalt = Namber + Namber2;
            break;
        case "-":
            resalt = Namber - Namber2;
            break;
        case "%":
            resalt = Namber % Namber2;
            break;
    }
    Console.WriteLine($"resalt = {resalt}");
    Console.WriteLine("go out? (\"yes\" or \"no\")");
    exid = Console.ReadLine();
} while (exid == "no");




















