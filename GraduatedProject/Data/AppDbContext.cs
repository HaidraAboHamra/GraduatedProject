using Microsoft.EntityFrameworkCore;

namespace GraduatedProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }
}
