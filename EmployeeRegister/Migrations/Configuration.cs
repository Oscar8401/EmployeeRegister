namespace EmployeeRegister.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccesslayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegister.DataAccesslayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Thomas",
                    LastName = "Smith",
                    Department = "IT",
                    Position = "Team leader",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Jenny",
                    LastName = "Eriksson",
                    Department = "IT",
                    Position = "Tester",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Pia",
                    LastName = "Olfsson",
                    Department = "Statics",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
            new Employee()
                {
                FirstName = "Prad",
                LastName = "bit",
                Department = "BI",
                Position = "Conection point",
                Salary = 2000
                });
        }
    }
}
