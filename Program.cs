int currentNumber;
string operation = "";
int modifyingNumber;
int getFirstNumber()
{
    return AskForNumber("Please specify the first number to use.");
}
int getSecondNumber()
{
    return AskForNumber("Please specify the next number to use.");
}
string getOperation()
{
    while (true)
    {
        Console.WriteLine("Please specify the math function to use.");
        Console.WriteLine("''+'' for addition.");
        Console.WriteLine("''-'' for subtraction.");
        Console.WriteLine("''*'' for multiplication.");
        Console.WriteLine("''/'' for division.");
        string operation = Console.ReadLine()!;
        if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            return operation;
        Console.WriteLine("Enter an operation");
    }
}
int calculatorMain(int currentNumber, string operation, int modifyingNumber)
{
    {
        switch (operation)
        {
            case "+":
                currentNumber += modifyingNumber;
                break;
            case "-":
                currentNumber -= modifyingNumber;
                break;
            case "*":
                currentNumber *= modifyingNumber;
                break;
            case "/":
                currentNumber /= modifyingNumber;
                break;
        }
    }
    return currentNumber;
}

int AskForNumber(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}
Console.WriteLine(calculatorMain(getFirstNumber(), getOperation(), getSecondNumber()));