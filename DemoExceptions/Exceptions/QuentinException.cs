namespace DemoExceptions.Exceptions;

internal class QuentinException : ArgumentException
{
    public string Value { get; set; }
    public QuentinException(string? message = "") : base(message)
    {
    }

    public QuentinException(string? message, string? paramName): base(message, paramName)
    {
        
    }
}
