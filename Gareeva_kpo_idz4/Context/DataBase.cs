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
    }
}