string name = "Tom";

switch (name)
{
    case "Bob":
        Console.WriteLine("Ваше имя - Bob");
        break;
    case "Tom":
        Console.WriteLine("Ваше имя - Tom");
        break;
    case "Sam":
        Console.WriteLine("Ваше имя - Sam");
        break;
    default:
        Console.WriteLine("Неизвестное имя");
        break;
}

// go to
int number = 1;
switch (number)
{
    case 1:
        Console.WriteLine("case 1");
        goto case 5; // goto case 5
    case 3:
        Console.WriteLine("case 3");
        break;
    case 5:
        Console.WriteLine("case 5");
        break;
    default:
        Console.WriteLine("default");
        break;
}

// return
int DoOperation(int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}
