// simle method
void SayHello()
{
    Console.WriteLine("Hello");
}

// call method
SayHello();

// short
void SayHello2() => Console.WriteLine("Hello");
SayHello2();

// params
void PrintMessage(string message)
{
    Console.WriteLine(message);
}
PrintMessage("Hi");
PrintMessage("Bye!");

// params with default values
//void PrintPerson(string name, int age = 1, string company = "Undefined")
//{
//    Console.WriteLine($"Name: {name}, Age: {age}, Company: {company}");
//}
//PrintPerson("Tom", 34, "ABC");
//PrintPerson("Bob", 25);
//PrintPerson("Pete");

// named params
void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Tom", company: "Microsoft", age: 37);  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson(age: 41, name: "Bob");          // Name: Bob  Age: 41  Company: Undefined
PrintPerson(company: "Google", name: "Sam"); // Name: Sam  Age: 1   Company: Google

// return value
string GetMessage()
{
    return "Hello";
}

PrintMessage(GetMessage());

// passing params via ref
void Increment(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");
Increment(ref number);
Console.WriteLine($"Число после метода Increment: {number}");

// out params
void Sum2(int x, int y, out int result)
{
    result = x + y;
}

int myNumber;

Sum2(10, 15, out myNumber);
Console.WriteLine(myNumber);

// array of params
void Sum3(params int[] numbers)
{
    int result = 0;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums = { 1, 2, 3, 4, 5 };
Sum3(nums);
Sum3(1, 2, 3, 4);
Sum3(1, 2, 3);
Sum3();