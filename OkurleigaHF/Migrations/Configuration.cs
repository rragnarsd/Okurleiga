namespace OkurleigaHF.Migrations
{
    
    using OkurleigaHF.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<OkurleigaHF.EF.OkDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
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
                Bedrooms = 3,
                RentCost = 150000,
                IsAvailable = false
            };

            Property p2 = new Property()
            {
                ZipCode = "101",
                Address = "Laugarvegur 50",
                PropertySize = 65,
                Bedrooms = 1,
                RentCost = 210000,
                IsAvailable = false
            };

            Property p3 = new Property()
            {
                ZipCode = "220",
                Address = "Fjarðargata 13",
                PropertySize = 80,
                Bedrooms = 2,
                RentCost = 180000,
                IsAvailable = false
             
            };

            Property p4 = new Property()
            {
                ZipCode = "235",
                Address = "Hafnargata 10",
                PropertySize = 120,
                Bedrooms = 4,
                RentCost = 240000,
                IsAvailable = false
            };

            Property p5 = new Property()
            {
                ZipCode = "260",
                Address = "Hjallavegur 10",
                PropertySize = 50,
                Bedrooms = 1,
                RentCost = 90000,
                IsAvailable = false
            };

            Property p6 = new Property()
            {
                ZipCode = "860",
                Address = "Austurvegur 4",
                PropertySize = 200,
                Bedrooms = 6,
                RentCost = 60000,
                IsAvailable = true
               
            };

            Property p7 = new Property()
            {
                ZipCode = "210",
                Address = "Garðatorg 7",
                PropertySize = 75,
                Bedrooms = 2,
                RentCost = 190000,
                IsAvailable = true
            };

            Property p8 = new Property()
            {
                ZipCode = "310",
                Address = "Borgarbraut 12",
                PropertySize = 130,
                Bedrooms = 4,
                RentCost = 100000,
                IsAvailable = true
            };

            Property p9 = new Property()
            {
                ZipCode = "540",
                Address = "Hnjúkabyggð 32",
                PropertySize = 300,
                Bedrooms = 5,
                RentCost = 85000,
                IsAvailable = true
            };

            Property p10 = new Property()
            {
                ZipCode = "260",
                Address = "Fífumói 6",
                PropertySize = 70,
                Bedrooms = 2,
                RentCost = 140000,
                IsAvailable = true
            };

            context.Properties.AddOrUpdate(
                a => a.Address,
                p1,
                p2,
                p3,
                p4,
                p5,
                p6,
                p7,
                p8,
                p9,
                p10
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

            Incident i1 = new Incident()
            {
                Title = "Baðherbergishurð",
                Property = p7,
                Description = "Hurð inn á baði er brotin",
                IsActive = false,
                IncidentClosedDate = new DateTime(2020, 01, 03)
            };

            Incident i2 = new Incident()
            {
                Title = "Eldhúsvifta",
                Property = p3,
                Description = "Viftan inn í eldhúsi virkar ekki",
                IsActive = true
            };

            context.Incidents.AddOrUpdate(
                i => i.Property,
                i1,
                i2
                );


            context.SaveChanges();
        }
    }
}
