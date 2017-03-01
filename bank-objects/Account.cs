using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Account
    {
        private List<Activity> _activity = new List<Activity>();
        private Random rnd = new Random();

        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        public Account(string account)
        {
            AccountNumber = account;
        }

        public void AddTransaction(decimal amount)
        {

            var date = DateTime.Now;
            /*DateTime start = new DateTime(2010, 1, 1);
            int range = (DateTime.Today - start).Days;
            var date =  start.AddDays(rnd.Next(range));*/
            date = date.AddDays(rnd.Next(1, 29)).AddMonths(rnd.Next(1,12));
            Balance += amount;
            _activity.Add(new Activity(date, amount));          
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
            foreach (var l in _activity.OrderBy(o => o.Timestamp.Date))
                Console.WriteLine(l);
        }

        public void ShowTransactions(DateTime startDate, DateTime endDate)
        {
            var selectAccount = (from d in _activity where d.Timestamp.Date >= startDate.Date && d.Timestamp.Date <= endDate.Date select d).OrderBy(o => o.Timestamp.Date);

            Console.WriteLine("\nAll transactions between {0:dd.MM.yyyy} and {1:dd.MM.yyyy}", startDate, endDate);
            Console.WriteLine("for account: " + AccountNumber);
            foreach (var d in selectAccount)
            {
                Console.WriteLine(d);
            }
           
        }
    }
}
