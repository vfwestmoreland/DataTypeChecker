Boolean valid = false;
string inputValueType;

Console.Write("Enter a value : ");
string inputValue = Console.ReadLine();

Console.WriteLine("Select the Data type to validate the input you have entered");
Console.WriteLine("Press 1 for String");
Console.WriteLine("Press 2 for Integer");
Console.WriteLine("Press 3 for Boolean");

Console.Write("Enter : ");
int inputType = Convert.ToInt32(Console.ReadLine());

switch (inputType)
{
    case 1:
        valid = IsAllAlphabetic(inputValue);
        inputValueType = "String";
        break;

    case 2:
        int retValue = 0;
        valid = int.TryParse(inputValue, out retValue);
        inputValueType = "Integer";
        break;

    case 3:
        bool retFlag = false;
        valid = bool.TryParse(inputValue, out retFlag);
        inputValueType = "Boolean";
        break;

    default:
        inputValueType = "unknown";
        Console.WriteLine("Not Able to Detect Input Type");
        break;
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"You have entered a value : {inputValue}");
if (valid)
{
    Console.WriteLine($"It is valid : {inputValueType}");
}
else
{
    Console.WriteLine($"It is an invalid : {inputValueType}");
}

Console.ReadKey();




static bool IsAllAlphabetic(string value)
{
    foreach (char c in value)
    {
        if (!char.IsLetter(c))
            return false;
    }

    return true;
}







Console.ReadLine();


/*static void GetOdd(int[] Array)
{
    foreach (int i in Array)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"This number is Even {i}");
        }
    }
}


static void GetEven(int[] Array)
{
    foreach (int i in Array)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine($"This number is Odd {i}");

        }
    }
}



int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

GetOdd(array);
GetEven(array);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
*/