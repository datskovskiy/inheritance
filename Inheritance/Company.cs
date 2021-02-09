using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (var employee in employees)
            {
                employee.SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay()
        {
            return employees.Sum(c => c.ToPay());
        }

        public string NameMaxSalary()
        {
            return employees.OrderByDescending(emp => emp?.ToPay()).FirstOrDefault()?.Name;
        }
    }
}
