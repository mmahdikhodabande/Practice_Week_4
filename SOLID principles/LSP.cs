using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class LSP
    {
        #region Wrong code
        public class Account
        {
            public virtual void Withdraw(double amount)
            {
                Console.WriteLine($"Withdrawing {amount} from account.");
            }
        }

        public class SavingsAccount : Account
        {
            public override void Withdraw(double amount)
            {
                if (amount > 500)
                {
                    throw new InvalidOperationException("Cannot withdraw more than 500 from a savings account.");
                }
                Console.WriteLine($"Withdrawing {amount} from savings account.");
            }
        }

        #endregion
        #region Correct code 
        public class Account
        {
            public virtual void Withdraw(double amount)
            {
                Console.WriteLine($"Withdrawing {amount} from account.");
            }
        }

        public class SavingsAccount : Account
        {
            public override void Withdraw(double amount)
            {
                ValidateWithdrawal(amount);
                base.Withdraw(amount);
            }

            private void ValidateWithdrawal(double amount)
            {
                if (amount > 500)
                {
                    throw new InvalidOperationException("Cannot withdraw more than 500 from a savings account.");
                }
            }
        }


        #endregion
    }
}
