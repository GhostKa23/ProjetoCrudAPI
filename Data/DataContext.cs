
using Microsoft.EntityFrameworkCore;
namespace ProjetoCrudAPI.Data
{
    public class DataContext : DbContext
    {
          public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}