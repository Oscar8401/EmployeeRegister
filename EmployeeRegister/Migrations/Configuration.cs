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
                    Department = "ST",
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
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Dimitris",
                    LastName = "Eriksson",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Olga",
                    LastName = "Ioansson",
                    Department = "HR",
                    Position = "recruiter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Stella",
                    LastName = "Talebsson",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Alex",
                    LastName = "Andersson",
                    Department = "BI",
                    Position = "IDL",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Cris",
                    LastName = "Obama",
                    Department = "HR",
                    Position = "Recruiter",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Tom",
                    LastName = "Magnisson",
                    Department = "IT",
                    Position = "Tester",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Barbara",
                    LastName = "Petersson",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Anna",
                    LastName = "Nykvist",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Anders",
                    LastName = "Larson",
                    Department = "IT",
                    Position = "Architecture",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Ebbi",
                    LastName = "Lunden",
                    Department = "HR",
                    Position = "Recruiter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Sofia",
                    LastName = "Dimitriou",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Sven",
                    LastName = "Papadopoulos",
                    Department = "BI",
                    Position = "Team Leadere",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Maria",
                    LastName = "mandeli",
                    Department = "IM",
                    Position = "IDL",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Jenny",
                    LastName = "Simsson",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "´Taleb",
                    LastName = "Mosyri",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Samantha",
                    LastName = "Erizona",
                    Department = "BI",
                    Position = "Developer",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Jack",
                    LastName = "Hayek",
                    Department = "IM",
                    Position = "IDL",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Monica",
                    LastName = "Bahar",
                    Department = "IT",
                    Position = "Tester",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Elisabeth",
                    LastName = "Femsson",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Jermy",
                    LastName = "Bittsson",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });

            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Anton",
                    LastName = "Lakomi",
                    Department = "IM",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Youssef",
                    LastName = "Palompa",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Ahmad",
                    LastName = "Marinopoulos",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Hassan",
                    LastName = "Gamatos",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Hadi",
                    LastName = "Kiporos",
                    Department = "HR",
                    Position = "Recruiter",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Samoyl",
                    LastName = "Petersson",
                    Department = "IT",
                    Position = "Staf responsible",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Sami",
                    LastName = "Alhado",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Nicoletta",
                    LastName = "tareq",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Sissy",
                    LastName = "Apostolou",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Alexandra",
                    LastName = "Sourlis",
                    Department = "HR",
                    Position = "Recruiter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Alexander",
                    LastName = "Greater",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Napoleon",
                    LastName = "Ponabart",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Ben Yamin",
                    LastName = "Yasar",
                    Department = "IM",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Barak",
                    LastName = "Bosh",
                    Department = "IT",
                    Position = "Tester",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Hellary",
                    LastName = "Obama",
                    Department = "ST",
                    Position = "Developer",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Henri",
                    LastName = "Klinton",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Robin",
                    LastName = "Houd",
                    Department = "HR",
                    Position = "Recruiter",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Vasiliki",
                    LastName = "Louloudou",
                    Department = "IT",
                    Position = "Tester",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Helen",
                    LastName = "Troya",
                    Department = "ST",
                    Position = "Developer",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Xenia",
                    LastName = "Alhamod",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Samir",
                    LastName = "masri",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Omar",
                    LastName = "Sliman",
                    Department = "HR",
                    Position = "Recruiter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "John",
                    LastName = "beker",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Oscar",
                    LastName = "Hydarsson",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Lary",
                    LastName = "Ferrari",
                    Department = "IM",
                    Position = "IDL",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Lars",
                    LastName = "Tash",
                    Department = "IT",
                    Position = "Tester",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Hans",
                    LastName = "Nygre",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Georg",
                    LastName = "Klone",
                    Department = "BI",
                    Position = "Developer",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Krister",
                    LastName = "Badi",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Ioan",
                    LastName = "Forgetsson",
                    Department = "IM",
                    Position = "Tester",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Ibrahim",
                    LastName = "Almaouasson",
                    Department = "ST",
                    Position = "Counter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Souzana",
                    LastName = "Makaratzi",
                    Department = "BI",
                    Position = "Developer",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Rama",
                    LastName = "Italiansson",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Souzi",
                    LastName = "Aljazaba",
                    Department = "HR",
                    Position = "Recruiter",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Mariela",
                    LastName = "Alheloua",
                    Department = "ST",
                    Position = "Developer",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Mariana",
                    LastName = "Snan",
                    Department = "BI",
                    Position = "Conection point",
                    Salary = 2000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Kasem",
                    LastName = "Amyn",
                    Department = "IT",
                    Position = "Developer",
                    Salary = 3000
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Leonel",
                    LastName = "Mesi",
                    Department = "IM",
                    Position = "Developer",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Gaberiel",
                    LastName = "Souper",
                    Department = "ST",
                    Position = "Developer",
                    Salary = 2500
                });
            context.Employees.AddOrUpdate(n => n.FirstName,
                new Employee()
                {
                    FirstName = "Brosli",
                    LastName = "Kich",
                    Department = "BI",
                    Position = "Developer",
                    Salary = 2000
                });
        }
    }
}
