namespace Base;

class Person
{
    string name;
    Company company;
    public Person(string name, Company company)
    {
        this.name = name;
        this.company = company;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name}");
        company.Print();
    }
}