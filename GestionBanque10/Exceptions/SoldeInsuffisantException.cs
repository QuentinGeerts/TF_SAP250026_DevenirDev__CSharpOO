namespace GestionBanque.Exceptions;

internal class SoldeInsuffisantException : Exception
{
    public string Message { get; private set; }

    public string Origin { get; private set; }

    public SoldeInsuffisantException(string message , string origin)
    {
        Message = message;
        Origin = origin;
    }

}
