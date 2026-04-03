using PooConcepts.Backend;
using System.Windows.Markup;

try
{
    var expenses = new List<IPay>();
    decimal total = 0;
    var employee1 = new SalaryEmployee(1, "Maria", "Perez", true, new Date(1990, 5, 15), new Date(2015, 3, 1), 2500000);
    expenses.Add(employee1);
    var employee2 = new SalaryEmployee(2, "Joaquín", "Gonzales", true, new Date(1980, 3, 5), new Date(2016, 11, 16), 10395876);
    expenses.Add(employee2);
    var employee3 = new HourlyEmployee(3, "Ana", "García", true, new Date(1995, 8, 20), new Date(2022, 6, 1), 18000, 95);
    expenses.Add(employee3);
    var employee4 = new HourlyEmployee(4, "Kevin", "Rua", true, new Date(1998, 8, 20), new Date(2021, 6, 1), 10000, 112);
    expenses.Add(employee4);
    var employee5 = new CommisionEmployee(5, "Sofia", "Lopez", true, new Date(1992, 12, 10), new Date(2018, 3, 15), 0.03f, 600000000);
    expenses.Add(employee5);
    var employee6 = new CommisionEmployee(6, "Diego", "Martinez", true, new Date(1985, 7, 30), new Date(2010, 9, 1), 0.03f, 120000000);
    expenses.Add(employee6);
    var employee7 = new BaseCommisionEmployee(7, "Laura", "Gomez", true, new Date(1990, 5, 15), new Date(2019, 5, 20), 0.015f, 250000000, 550000); 
    expenses.Add(employee7);
    var employee8 = new BaseCommisionEmployee(8, "Carlos", "Rodriguez", true, new Date(1988, 3, 5), new Date(2026, 2, 10), 0.015f, 0, 550000);
    expenses.Add(employee8);
    var invoice1 = new Invoice(9090, "Iphone 14 Pro Max", new Date(2024, 6, 1), 2, 8000000);
    expenses.Add(invoice1);
    var invoice2 = new Invoice(1010, "Samsung Galaxy S24 Ultra", new Date(2024, 6, 1), 3, 7000000); 
    expenses.Add(invoice2);
    var invoice3 = new Invoice(1012, "UTP level 6", new Date(2024, 6, 1), 100.45f, 6450);
    expenses.Add(invoice3);
    foreach (var expense in expenses)
    {
        Console.WriteLine(new string('-', 48));
        Console.WriteLine(expense);
        total += expense.GetValueToPay();
    }
    Console.WriteLine(new string('=', 48));
    Console.WriteLine($"Total.......................:{total,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}