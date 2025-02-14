using desafio6.Domain.Enum;
using System.Net;

namespace desafio6.Domain.Exceptions;

public class desafio6DomainException : Exception
{
    public ErrorCodeEnum ErrorCode { get; set; }
    public HttpStatusCode? StatusCode { get; set; }

    public desafio6DomainException(string message, ErrorCodeEnum errorCode, HttpStatusCode? statusCode = null) : base(message)
    {
        this.ErrorCode = errorCode;
        this.StatusCode = statusCode;
    }

    public desafio6DomainException(string message, ErrorCodeEnum errorCode, Exception innerException, HttpStatusCode? statusCode = null) : base(message, innerException)
    {
        this.ErrorCode = errorCode;
        this.StatusCode = statusCode;
    }
}