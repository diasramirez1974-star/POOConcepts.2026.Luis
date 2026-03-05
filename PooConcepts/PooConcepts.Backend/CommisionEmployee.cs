using System;
using System.Collections.Generic;
using System.Text;

namespace PooConcepts.Backend;

public class CommisionEmployee : Employee
{
    // Fields
    private float _commissionPercent;
    private decimal _sales;





    // Constructors
    public CommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commissionPercent, decimal sales) :
        base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        CommissionPercent = commissionPercent;
        Sales = sales;
    }

    // Properties

    public float CommissionPercent
    {
        get => _commissionPercent;
        set => _commissionPercent = ValidateCommissionPercent(value);
    }
    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }


    // Methods
    public override decimal GetValueToPay()
    {
        return (decimal)CommissionPercent * Sales;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n\tCommission Percent: {CommissionPercent,20:P2}" +
                                 $"\n\tSales.............: {Sales,20:C2}";
    }

    private float ValidateCommissionPercent(float commissionPercent)
    {
        if (commissionPercent < 0 || commissionPercent > 1)
        {
            throw new ArgumentOutOfRangeException(nameof(commissionPercent), "Commission percent must be between 0 and 1.");
           
        }
        return commissionPercent;
    }
    
    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than or equal to 0.");
        }    
        return sales;
    }

}

