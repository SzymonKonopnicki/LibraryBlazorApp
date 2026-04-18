using Microsoft.AspNetCore.Identity;

namespace LibraryBlazorApp.Infrastructure.Identity;

public class LocalizedIdentityErrorDescriber : IdentityErrorDescriber
{
    private const string Password = "Password";
    private const string Email = "Email";

    public override IdentityError PasswordMismatch()
    {
        return new IdentityError
        {
            Code = Password,
            Description = "Password and Confirmed Password are different."
        };
    }

    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError
        {
            Code = Password,
            Description = "The password must contain at least 1 digit."
        };
    }

    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError
        {
            Code = Password,
            Description = "The password must contain at least 1 lowercase letter."
        };
    }

    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        return new IdentityError
        {
            Code = Password,
            Description = "The password must contain at least 1 special character (e.g. $, #, &, etc.)."
        };
    }

    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError
        {
            Code = Password,
            Description = "The password must contain at least 1 uppercase letter."
        };
    }

    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError
        {
            Code = Password,
            Description = "The password must be at least 8 characters and no more than 100 characters."
        };
    }

    public override IdentityError DuplicateUserName(string userName)
    {
        return new IdentityError
        {
            Code = Email,
            Description = "The selected email is already taken."
        };
    }
}
