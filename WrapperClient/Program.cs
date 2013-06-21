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

            Console.WriteLine(btc.DumpPrivKey("1BP4T1MQZffcF6v78swNnUYHyfLYBs1oWU"));

            // NEED TO TEST:
            //getaccountaddress,
            //getaddressesbyaccount,
            //getblocktemplate,
            //getconnectioncount,
            //getnewaddress,
            //getreceivedbyaccount,
            //getreceivedbyaddress,
            //gettransaction,
            //getwork,
            //help,
            //listaccounts,
            //listaddressgroupings,
            //listreceivedbyaccount,
            //listreceivedbyaddress,
            //listinceblock,
            //listtransactions,
            //listlockunspent,
            //settxfee,
            //walletlock

            Console.ReadKey();
        }
    }
}
