
Person tom = new Person();
Console.WriteLine(tom.name);
Console.WriteLine(tom.age);

tom.name = "Tom";
tom.age = 10;

tom.Print();
class Person
{
    public string name = "Undefined";
    public int age;

public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

