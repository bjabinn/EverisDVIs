using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class VdiContext : DbContext
    {
        public DbSet<Environment> Enviroments { get; set; }
        public DbSet<VirtualMachine> VirtualMachines { get; set; }
        public DbSet<EnvironmentVirtualMachine> EnvironmentVirtualMachines { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusVirtualMachine> StatusVirtualMachines { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<VisitMode> VisitModes { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VdiTest;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VdiTest;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Environment>().ToTable("Enviroment");
            modelBuilder.Entity<VirtualMachine>().ToTable("VirtualMachine");
            modelBuilder.Entity<EnvironmentVirtualMachine>().ToTable("EnvironmentVirtualMachine");
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<StatusVirtualMachine>().ToTable("StatusVirtualMachine");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Operation>().ToTable("Operation");
            modelBuilder.Entity<VisitMode>().ToTable("VisitMode");

        }
    }
}
