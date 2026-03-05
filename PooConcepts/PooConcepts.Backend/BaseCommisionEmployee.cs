using System;
using System.Collections.Generic;
using System.Text;

namespace PooConcepts.Backend;

public class BaseCommisionEmployee : CommisionEmployee
{
    // Fields
    private decimal _salary;




    // Constructors
    public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commissionPercent, decimal sales, decimal salary) :
        base(id, firstName, lastName, isActive, bornDate, hireDate, commissionPercent, sales)
    {
        Salary = salary;
    }
    // Properties
    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }
    // Methods

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 500000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $500,000.");
        }
        return salary;
    }

    public override decimal GetValueToPay()
    {
        return Salary + base.GetValueToPay();
    }

    public override string ToString()
    {
        return base.ToString() + $"\n\tSalary............: {Salary,20:C2}";
    }

}
