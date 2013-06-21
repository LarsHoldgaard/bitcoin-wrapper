using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitcoinWrapper.Wrapper;

namespace WrapperClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BtcConnector btc = new BtcConnector();
            var balance = btc.GetBalance().ToString();
            Console.WriteLine(balance);
            Console.ReadKey();
        }
    }
}
