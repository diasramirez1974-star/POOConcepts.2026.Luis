using PooConcepts.Backend;

try
{
    var employee1 = new SalaryEmployee(1, "Maria", "Perez", true, new Date(1990, 5, 15), new Date(2015, 3, 1), 2500000);
    var employee2 = new SalaryEmployee(1, "Joaquín", "Gonzales", true, new Date(1980, 3, 5), new Date(2010, 11, 15), 10395876);
    Console.WriteLine(employee1);
    Console.WriteLine(employee2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}