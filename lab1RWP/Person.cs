using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1RWP
{
    internal class Person: IPerson
    {
        public Person(string Name, int CardNumber, DateTime Birthday) 
        {
            this.Name = Name;  
            this.CardNumber = CardNumber;
            this.Bithday = Birthday;
        }
        public int CardNumber { get; set; }
        public string Name { get; set; }
        public DateTime Bithday { get; set; }
        public int CalcAge(DateTime date) 
        {
            var age=DateTime.Now.Year-date.Year;
            if (DateTime.Now.Month < date.Month ||
                (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)) age--;

            return age;
        }
        public void SetName(string name) {Name= name;}
        public void SetBithday(DateTime date) { Bithday= date; }
        public void SetCardNumber(int cardnumber) { CardNumber = cardnumber; }
        
    }
}
