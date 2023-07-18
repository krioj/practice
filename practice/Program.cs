using System.Diagnostics.CodeAnalysis;
string exid;
do
{
    Console.WriteLine("write 2 numbers");

    float Namber = float.Parse(Console.ReadLine());
    float Namber2 = float.Parse(Console.ReadLine());
    float sum = 0;
    Console.WriteLine("what do you want to do? (/, *, +, -, %)");

    switch (Console.ReadLine())
    {
        case "/":
            sum = Namber / Namber2;
            break;
        case "*":
            sum = Namber * Namber2;
            break;
        case "+":
            sum = Namber + Namber2;
            break;
        case "-":
            sum = Namber - Namber2;
            break;
        case "%":
            sum = Namber % Namber2;
            break;
    }
    Console.WriteLine($"sum = {sum}");
    Console.WriteLine("go out? (\"yes\" or \"no\")");
    exid = Console.ReadLine();
} while (exid == "no");




















