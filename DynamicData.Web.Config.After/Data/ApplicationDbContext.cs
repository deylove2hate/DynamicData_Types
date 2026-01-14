using Microsoft.EntityFrameworkCore;

namespace DynamicData.Web.Config.After.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}