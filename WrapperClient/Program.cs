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
            BaseBtcConnector btc = new BaseBtcConnector();
            
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
