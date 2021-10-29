using Microsoft.EntityFrameworkCore;

namespace finstar.db {
    public class RecordsContext : DbContext {
        public DbSet<Record> Records { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=FinstarBD;Trusted_Connection=True");
        }

    }
}
