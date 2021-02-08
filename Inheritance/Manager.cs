using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class Manager : Employee
    {
        private int quantity;

        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            this.quantity = clientAmount;
        }

        public override void SetBonus(decimal bonus)
        {
            decimal additionalBonus = 0;
            if (quantity > 100 && quantity <= 150)
                additionalBonus = 500;
            else if (quantity > 150)
                additionalBonus = 1000;

            base.SetBonus(bonus + additionalBonus);
        }
    }
}

