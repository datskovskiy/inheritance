using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class SalesPerson: Employee
    {
        private int percent;

        public SalesPerson(string name, decimal salary, int percent): base(name, salary)
        {
            this.percent = percent;
        }

        public override void SetBonus(decimal bonus)
        {
            int coefficient = 1;
            if (percent > 100 && percent <= 200)
                coefficient = 2;
            else if(percent > 200)
                coefficient = 3;

            base.SetBonus(bonus * coefficient);
        }
    }
}
