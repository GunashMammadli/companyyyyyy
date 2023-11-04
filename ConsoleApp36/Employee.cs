namespace ConsoleApp36;
internal class Employee : Person
{
    public int Salary { get; set; }
    public string Position { get; set; }
    public enum Gender
    {
        Male,
        Female,
        Other,
    }
    public override string ToString()
    {
        return $"ID: {ID} \n Name: {Name} \n Surname: {Surname} \n Age: {Age}  \n Position: {Position} \n Salary: {Salary}";
    }
}
