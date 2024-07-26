Person tom = new Person("Tom", 10);
tom.Print();

// copy structure
Person bob = tom with { name = "Bob" };
bob.Print();

struct Person
{
    public string name;
    public int age;

    // constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}