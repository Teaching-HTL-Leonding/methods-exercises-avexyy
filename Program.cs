string selection;
do
{
    Console.Clear();
    Console.WriteLine("What do you want to execute?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Calculate Circle Area");
    Console.WriteLine("1. Random in Range");
    Console.WriteLine("2. To FizzBuzz");
    Console.WriteLine("3. Fibonacci by Index");
    Console.WriteLine("4. Ask for Number in Range");
    Console.WriteLine("5. Is palindrome?");
    Console.WriteLine("6. Is palindrome? (advanced)");
    Console.WriteLine("7. Chart Bar");
    Console.WriteLine("8. Count Smiling Faces");
    Console.WriteLine("q to Quit");
    selection = Console.ReadLine()!;

    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0": RunCalculateCircleArea(); break;
            case "1": RunRandomInRange(); break;
            case "2": RunToFizzBuzz(); break;
            case "3": RunFibonacciByIndex(); break;
            case "4": RunAskForNumberInRange(); break;
            case "5": RunIsPalindrome(); break;
            default: break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "q");


#region Calculate Circle Area
void RunCalculateCircleArea()
{
    Console.Write("Enter radius:");
    var radius = double.Parse(Console.ReadLine()!);
    var area = CalculateCircleArea(radius);
    Console.WriteLine($"Area of circle with radius {radius} is {area}");
}

double CalculateCircleArea(double radius)
{
    return radius * radius * Math.PI;
}
#endregion


#region Random In Range
void RunRandomInRange()
{
    System.Console.Write("Enter the minimum value: ");
    var minVal = int.Parse(Console.ReadLine()!);
    System.Console.Write("Enter the maximum value: ");
    var maxVal = int.Parse(Console.ReadLine()!);

    var random = RandomInRange(minVal, maxVal);
    System.Console.WriteLine($"The random number is {random}");
}

int RandomInRange(int minVal, int maxVal)
{
    return Random.Shared.Next(minVal, maxVal + 1);
}
#endregion

#region ToFizzBuzz
void RunToFizzBuzz()
{
    System.Console.Write("Enter a int number: ");
    int number = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine($"{ToFizzBuzz(number)}");
}

string ToFizzBuzz(int number)
{
    if (number % 15 == 0)
    {
        return "FizzBuzz";
    }
    else if (number % 5 == 0)
    {
        return "Buzz";
    }
    else if (number % 3 == 0)
    {
        return "Fizz";
    }
    return number.ToString();
}
#endregion

#region FibonacciByIndex
void RunFibonacciByIndex()
{

}


#endregion

#region AskForNumberInRange
void RunAskForNumberInRange()
{
    System.Console.Write("Enter a minimum: ");
    int min = int.Parse(System.Console.ReadLine()!);
    System.Console.Write("Enter a maximum: ");
    int max = int.Parse(System.Console.ReadLine()!);
    System.Console.WriteLine($"Please enter a value between {min} and {max}");
    int number = int.Parse(Console.ReadLine()!);
    if (number >= min && number <= max)
    {
        System.Console.WriteLine("Thank you, your input is valid.");
    }
    else
    {
        do
        {
            AskForNumberInRange(min, max, number);
        } while (!(number >= min && number <= max));
    }

}

int AskForNumberInRange(int min, int max, int number)
{
    if (number < min)
    {
        System.Console.WriteLine($"Wrong number. Your input is too low. The minimum is {min}. Try again!");
        number = int.Parse(Console.ReadLine()!);
    }
    else if (number > max)
    {
        System.Console.WriteLine($"Wrong number. Your input is too high. The maximum is {max}. Try again!");
        number = int.Parse(Console.ReadLine()!);
    }
    return number;
}
#endregion

#region IsPalindrome
void RunIsPalindrome()
{
    System.Console.Write("Enter a string to check if it is a palindrome: ");
    string input = Console.ReadLine()!;
    string reverse = "";
    System.Console.WriteLine($"{IsPalindrome(input, reverse)}");
}

bool IsPalindrome(string input, string reverse)
{
    for (int i = input.Length - 1; i >= 0; i--)
    {
        reverse += input[i];
    }
    if (reverse == input)
    {
        return true;
    }
    else
    {
        return false;
    }
}
#endregion

#region Chart Bar

#endregion