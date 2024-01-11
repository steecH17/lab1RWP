using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1RWP
{
    public interface IPerson
    {
        int CardNumber { get; }
        string Name { get; }
        DateTime Bithday { get; }
        int CalcAge(DateTime date);
        void SetName(string name);
        void SetBithday(DateTime date);
        void SetCardNumber(int cardNumber);

    }


}
