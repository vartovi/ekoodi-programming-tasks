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
        private readonly List<Account>_accounts = new List<Account>();
        public static Random rnd = new Random();

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

        private static string GenerateAccNmbr()
        {
            return "FI" + rnd.Next(10000000, 99999999) + rnd.Next(10000000, 99999999);
        }

        public override string ToString()
        {
            return  $"Bank: {_name}";
        }

        public void ShowAccounts()
        {
            foreach (var l in _accounts)
                Console.WriteLine(l);
        }

        public void NewTransaction(string account, decimal activity)
        {
            var selectAccount = from num in _accounts where Convert.ToString(num) == account select num;
            
            foreach (var num in selectAccount)
            {
                num.AddTransaction(activity);
            }                            
        }

        public void GetBalance(string account)
        {
            var selectAccount = _accounts.First(item => item.ToString() == account);

            Console.WriteLine("Your current balance is: " + selectAccount.ReturnBalance());

        }

        public void GetTransactions(string account, string startDate, string endDate)
        {
            var selectAccount = _accounts.First(item => item.AccountNumber == account);
            selectAccount.ShowTransactions(Convert.ToDateTime(startDate), Convert.ToDateTime(endDate));
        }

        public void GetAllTransactions(string account)
        {
            var selectAccount = _accounts.First(item => item.AccountNumber == account);
            selectAccount.ShowAllTransactions();
        
        }

    }
}
