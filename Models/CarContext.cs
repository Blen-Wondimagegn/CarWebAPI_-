
using Microsoft.EntityFrameworkCore;

namespace CarWebAPI.Models
{
    public class CarContext  : DbContext
     {
         public CarContext(DbContextOptions<CarContext> options)
             : base(options)
         {
         }

         public DbSet<Car> cars { get; set; }
     }
}