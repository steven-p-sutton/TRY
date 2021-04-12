public class EmployeeNotImplentedException : BaseException
{
    public EmployeeNotImplentedException()
    {
        this.Name = "EmployeeNotImplentedException";
    }
    public EmployeeNotImplentedException(string message)
        : base(message)
    {
    }
    public EmployeeNotImplentedException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public override string Display()
    {
        return this.Display();
    }
}
public class EmployeeAlreadyExistsException : BaseException
{
    public EmployeeAlreadyExistsException()
    {
        this.Name = "EmployeeAlreadyExistsException";
    }
    public EmployeeAlreadyExistsException(string message)
        : base(message)
    {
    }
    public EmployeeAlreadyExistsException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public override string Display()
    {
        return this.Display();
    }
}
public class EmployeeNotFoundException : BaseException
{
    public EmployeeNotFoundException()
    {
        this.Name = "EmployeeNotFoundException";
    }
    public EmployeeNotFoundException(string message)
        : base(message)
    {
    }
    public EmployeeNotFoundException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public override string Display()
    {
        return this.Display();
    }
}
