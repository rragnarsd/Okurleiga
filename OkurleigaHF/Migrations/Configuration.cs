namespace OkurleigaHF.Migrations
{
    
    using OkurleigaHF.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<OkurleigaHF.EF.OkDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OkurleigaHF.EF.OkDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Property p1 = new Property()
            {
                ZipCode = "245",
                Address = "Lækjamót 1",
                PropertySize = 100,
                RentCost = 150000
            };

            Property p2 = new Property()
            {
                ZipCode = "101",
                Address = "Laugarvegur 50",
                PropertySize = 65,
                RentCost = 210000
            };

            Property p3 = new Property()
            {
                ZipCode = "220",
                Address = "Fjarðargata 13",
                PropertySize = 80,
                RentCost = 180000
            };

            Property p4 = new Property()
            {
                ZipCode = "235",
                Address = "Hafnargata 10",
                PropertySize = 120,
                RentCost = 240000
            };

            Property p5 = new Property()
            {
                ZipCode = "260",
                Address = "Hjallavegur 10",
                PropertySize = 50,
                RentCost = 90000
            };

            context.Properties.AddOrUpdate(
                a => a.Address,
                p1,
                p2,
                p3,
                p4,
                p5
                );

            Tenant t1 = new Tenant()
            {
                FullName = "Regína Ragnarsdóttir",
                Email = "reginaragnarsd@gmail.com",
                Phone = 7722330,
                PropertyForRent = p2
            };

            Tenant t2 = new Tenant()
            {
                FullName = "Arna Vala Eggertsdóttir",
                Email = "arnav@gmail.com",
                Phone = 8882222,
                PropertyForRent = p4
            };

            Tenant t3 = new Tenant()
            {
                FullName = "Hjörtur Pálmi",
                Email = "hjortur@gmail.com",
                Phone = 4439993,
                PropertyForRent = p1
            };

            Tenant t4 = new Tenant()
            {
                FullName = "Birgir Jónsson",
                Email = "birgir@yahoo.com",
                Phone = 8672383,
                PropertyForRent = p5
            };

            Tenant t5 = new Tenant()
            {
                FullName = "Guðlaug Hauksdóttir",
                Email = "gudlaug@hi.is",
                Phone = 7383887,
                PropertyForRent = p3
            };

            context.Tenants.AddOrUpdate(
                b => b.FullName,
                t1,
                t2,
                t3,
                t4,
                t5
                );

            context.SaveChanges();
        }
    }
}
