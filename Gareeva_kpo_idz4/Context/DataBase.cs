using Microsoft.EntityFrameworkCore;
using Gareeva_kpo_idz4.Tables;

namespace Gareeva_kpo_idz4.Context
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions<DataBase> options)
            : base(options)
        {

        }
        public DbSet<User>? User { get; set; }
        public DbSet<Session>? Session { get; set; }
        public DbSet<Order>? Order { get; set; }
        public DbSet<Dish>? Dish { get; set; }
        public DbSet<DishOrder>? DishOrder { get; set; }

    }
}