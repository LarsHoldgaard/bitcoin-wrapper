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
            var block = btc.GetBlock("00000000000000bcb70563b6444d439ea1d079460c39500f5a9cfb270df09c0b");
            var txId = block.Tx[0];
            var rawTransaction = btc.GetRawTransaction(txId);
            var transaction = btc.DecodeRawTransaction(rawTransaction);

            Console.WriteLine(btc.GetAccount("1BP4T1MQZffcF6v78swNnUYHyfLYBs1oWU"));

            Console.WriteLine(balance);
            Console.ReadKey();
        }
    }
}
