namespace ConsoleApp36;
internal abstract class Person
{
    private static int _id = 0;
    public int ID { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person()
    {
        _id++;
        ID = _id;
    }

    public virtual string Fullname()
    {
        return $"{Name} {Surname}";
    }
}
