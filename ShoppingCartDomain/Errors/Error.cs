using System;

namespace ShoppingCartDomain.Errors;

public class Error : IEquatable<Error>
{
    public static readonly Error noneError = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new($"{nameof(Error)}.{nameof(NullValue)}", "The result value is null");
    public static readonly Error CondationNotSatisfied = new($"{nameof(Error)}.{nameof(CondationNotSatisfied)}", "The specified condition not satisfied");
    public static readonly Error ValidationError = new($"{nameof(Error)}.{nameof(ValidationError)}", "Validation error");
    public string Code{ get; }
    public string Message{ get; }
    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }
    public static Error New(string code,string message)
    {
        return new Error(code, message);
    }
    public bool Equals(Error? other)
    {
        if (other == null)
        {
            return false;
        }
        return Code == other.Code && Message == other.Message;
    }
}
