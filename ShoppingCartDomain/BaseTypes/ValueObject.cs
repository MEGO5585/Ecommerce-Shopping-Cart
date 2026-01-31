using System;

namespace ShoppingCartDomain.BaseTypes;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public bool Equals(ValueObject? other)
    {
        throw new NotImplementedException();
    }
}
