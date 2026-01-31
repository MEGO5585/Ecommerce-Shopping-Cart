using System;
using ShoppingCartDomain.BaseTypes;
using ShoppingCartDomain.Errors;
using ShoppingCartDomain.Utilities;

namespace ShoppingCartDomain.ValueObjects;

public sealed class Username : ValueObject
{
    public const int maxValue = 50;
    public string? Value { get; }
    private Username(string value)
    {
        Value = value;
    }
    public static Username Create(string username)
    {
        return new Username(username);
    }
    public IList<Error> Validate(string username)
    {
        return ListUtilities.EmptyList<Error>();
    }

}
