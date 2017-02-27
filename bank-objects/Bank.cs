using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Bank
    {
        private readonly string _name;
        private readonly IList<Account>_accounts = new List<Account>();
        static Random rnd = new Random();

        public Bank(string name)
        {
            _name = name;
        }

        public string NewAccount()
        {
            var account = GenerateAccNmbr();
            _accounts.Add(new Account(account));
            return account;
        }

        private string GenerateAccNmbr()
        {        
            return "FI" + rnd.Next(10000000, 99999999) + rnd.Next(10000000, 99999999);
        }

        public override string ToString()
        {
            return  $"Bank: {_name}";
        }

        public void Accounts()
        {
            foreach (var l in _accounts)
                Console.WriteLine(l);
        }

        public void NewActivity(string account)
        {
           
        }

        public decimal GetBalance(string account)
        {
            return 0;
        }

        public void GetActivity(string account, string time)
        {
            
        }

        public void GetAllActivity(string account)
        {
            
        }

    }
}
