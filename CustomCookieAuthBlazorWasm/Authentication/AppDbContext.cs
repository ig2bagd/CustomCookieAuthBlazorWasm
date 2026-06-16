using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomCookieAuthBlazorWasm.Authentication;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AppUser>(options)
{
    //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //public AppDbContext() { }
}
