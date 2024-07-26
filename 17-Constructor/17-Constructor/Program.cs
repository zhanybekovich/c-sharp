Person tom = new Person();
tom.Print();

Person bob = new Person("bob");
bob.Print();

Person pete = new Person("pete", 25);
pete.Print();

//Object initializers
Person john = new Person { name = "John", age = 25 };
john.Print();

// using deconstrucotor
(string name, int age) = john;
Console.WriteLine(name);
Console.WriteLine(age);

class Person
{
    public string name;
    public int age;

    // 1st constructor
    public Person()
    {
        this.name = "Undefined";
        this.age = 18;
    }

    // 2nd constructor
    public Person(string n)
    {
        this.name = n;
        this.age = 18;
    }

    // 3rd constructor
    public Person(string n, int a)
    {
        this.name = n;
        this.age = a;
    }

    // deconstructor
    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    
}