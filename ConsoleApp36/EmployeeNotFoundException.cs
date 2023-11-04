namespace ConsoleApp36;
internal class EmployeeNotFoundException : Exception
{
    public EmployeeNotFoundException()
    {
    }

    public EmployeeNotFoundException(string? message) : base(message)
    {
    }
}
