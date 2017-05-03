using System.Linq;

namespace Models
{
    public static class DbInitializer
    {
        public static void Initialize(VdiContext context)
        {
            context.Database.EnsureCreated();

            if (context.Enviroments.Any())
            {
                return;   // DB has been seeded
            }

            var enviroments = new[]
            {
                new VirtualMachine { Name = "VDIX1",   Ip = "10.0.0.1",
                    Tpx = "", Password = ""},
                new VirtualMachine { Name = "VDIX2", Ip = "10.0.0.2",
                    Tpx = "", Password = ""},
                new VirtualMachine { Name = "VDIX2",   Ip = "10.0.0.3",
                    Tpx = "", Password = ""} 
            };

            foreach (var s in enviroments)
            {
                context.VirtualMachines.Add(s);
            }
            context.SaveChanges();
        }
    }
}
