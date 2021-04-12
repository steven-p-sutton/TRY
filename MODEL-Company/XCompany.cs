public class CompanyNotImplentedException : BaseException
{
    public CompanyNotImplentedException()
    {
        this.Name = "CompanyNotImplentedException";
    }
    public CompanyNotImplentedException(string message)
        : base(message)
    {
    }
    public CompanyNotImplentedException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {
        return this.Display();
    }
}
public class CompanyAlreadyExistsException : BaseException
{
    public CompanyAlreadyExistsException()
    {
        this.Name = "CompanyAlreadyExistsException";
    }
    public CompanyAlreadyExistsException(string message)
        : base(message)
    {
    }
    public CompanyAlreadyExistsException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {
        return this.Display();
    }
}
public class CompanyNotFoundException : BaseException
{
    public CompanyNotFoundException()
    {
        this.Name = "CompanyNotFoundException";
    }
    public CompanyNotFoundException(string message)
        : base(message)
    {
    }
    public CompanyNotFoundException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {
        return this.Display();
    }
}
