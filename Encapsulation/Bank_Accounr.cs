using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{
    public class Bank_Accounr
    {
        private const decimal MAX=800;
        private int Account_Number;
        private decimal _Balance;

        public void SetAccount_Number(int Account_Number)
        {
            this.Account_Number = Account_Number;

        }
        public int GetAccount_Number()
        {
            return Account_Number;
        }
        public void Set_Balance(decimal _Balance)
        {
            this._Balance = _Balance;

        }
        public decimal Get_Balance()
        {
            return _Balance;
        }
        public decimal deposite(decimal amount)
        {
            _Balance = _Balance + amount;
            return _Balance;

        }

        public decimal withDraw(decimal amount)
        {
            if(amount > MAX)
            {
                Console.WriteLine("Check your Balance");
            }
             if(amount>_Balance)
            {

                Console.WriteLine("Your Balance is less than your amount");
            }
            else
            {
                _Balance=_Balance-amount;
                Console.WriteLine($"Your Balance is : {_Balance}");
            }
            return _Balance;
        }






    }
}
