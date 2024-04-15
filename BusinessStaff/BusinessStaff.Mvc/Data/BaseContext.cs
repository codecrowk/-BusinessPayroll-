using Microsoft.EntityFrameworkCore;

namespace BusinessStaff.Mvc.Data
{
  public class BaseContext : DbContext
  {
    public BaseContext (DbContextOptions<BaseContext> options) : base (options)
    { }
  }
}