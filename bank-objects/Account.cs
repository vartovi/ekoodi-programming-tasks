using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Account
    {
        private string _account;
        private List<Activity> _activity = new List<Activity>();
        private decimal _balance;
        private Random rnd = new Random();

        public string AccountNumber
        {
            get { return _account; }
            set { _account = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public Account(string account)
        {
            _account = account;
        }

        public void AddTransaction(decimal amount)
        {
            //var date = new DateTime(2017, 02, 28);
            //var time = new TimeSpan(rnd.Next(1,25), rnd.Next(1,60), rnd.Next(1,59));
            var date = DateTime.Now;
            //date = date.Date + time;
            date = date.AddDays(rnd.Next(1, 29)).AddMonths(rnd.Next(1,12));
            _activity.Add(new Activity(date, amount));
            Balance += amount;
            //Console.WriteLine("New transaction: {0} \tBalance now {1}",amount, Balance);
        }

        public decimal ReturnBalance()
        {
            return Balance;
        }

        public override string ToString()
        {
            return AccountNumber;
        }

        public void ShowAllTransactions()
        {
            Console.WriteLine("\nAll transactions for account " + AccountNumber);
            foreach (var l in _activity)
                Console.WriteLine(l);
        }

        public void ShowTransactions(DateTime startDate, DateTime endDate)
        {
            var selectAccount = from d in _activity where d.Timestamp.Date >= startDate.Date && d.Timestamp.Date <= endDate.Date select d;

            Console.WriteLine("\nAll transactions between {0:dd.MM.yyyy} and {1:dd.MM.yyyy}", startDate, endDate);
            foreach (var d in selectAccount)
            {
                Console.WriteLine(d);
            }
        }
    }
}
