using System;

namespace ShoppingCartDomain.EntityIds;

public readonly record struct UserId
{
    public Guid value{ get; }
    private UserId(Guid id)
    {
        value = id;
    }
    public static UserId Create(Guid id)
    {
        return new UserId(id);
    }

}
