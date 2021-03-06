using LibrarySystem.Models;

namespace LibrarySystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<LibrarySystem.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "LibrarySystem.Data.ApplicationDbContext";
        }

        protected override void Seed(LibrarySystem.Data.ApplicationDbContext context)
        {
//            if (context.Laptops.Count() > 0)
//            {
//                return;
//            }
//
//            Random rand = new Random();
//
//            Manufacturer sampleManufacturer = new Manufacturer { Name = "Lenovo" };
//            ApplicationUser user = new ApplicationUser() { UserName = "TestUser", Email = "TestMail@test.com" };
//
//            for (int i = 0; i < 10; i++)
//            {
//                Laptop laptop = new Laptop();
//                laptop.HardDisk = rand.Next(10, 1000);
//                laptop.ImageUrl = "http://laptop.bg/system/images/26207/thumb/toshiba_satellite_l8501v8.jpg";
//                laptop.Manufacturer = sampleManufacturer;
//                laptop.Model = "ideapad";
//                laptop.MonitorSize = 15.4;
//                laptop.Price = rand.Next(600, 3000);
//                laptop.RamMemory = rand.Next(1, 16);
//                laptop.Weight = 3;
//
//                var votesCount = rand.Next(0, 10);
//                for (int j = 0; j < votesCount; j++)
//                {
//                    laptop.Votes.Add(new Vote { Laptop = laptop, VotedBy = user });
//                }
//
//                var commentsCount = rand.Next(0, 10);
//                for (int j = 0; j < commentsCount; j++)
//                {
//                    laptop.Comments.Add(new Comment { Content = "Mnou qk laptop brat.", Author = user });
//                }
//
//                context.Laptops.Add(laptop);
//            }
//
//            context.SaveChanges();
//
//            base.Seed(context);
        }
    }
}
