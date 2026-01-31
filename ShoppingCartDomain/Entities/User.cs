using System;
using ShoppingCartDomain.EntityIds;
using ShoppingCartDomain.ValueObjects;

namespace ShoppingCartDomain.Entities;

public sealed class User
{
    public Username Username {get; set;}
    public Email Email {get; set;}
    public PasswordHash PasswordHash {get; set;}
    private User(UserId id,Username username,Email email)
    {
        
    }
    public static User Create(UserId id,Username username, Email email)
    {
        var user = new User(id, username, email);
        return user;
    }

}
