using Microsoft.AspNetCore.Identity;

namespace CustomCookieAuthBlazorWasm.Authentication;

public class AppUser : IdentityUser
{
    public string? Name { get; set; }
}
