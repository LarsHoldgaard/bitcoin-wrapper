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
            btc.GetBalance();
            
            // NEED TO TEST:
            // sendtransaction (requires unlock)
        //    addnode,
        //getaddednodeinfo,
        //gettxout,
        //gettxoutsetinfo,
        //keypoolrefill,
        //sendfrom,
        //signmessage,
        //submitblock,
        //verifymessage,
        //walletpassphrase,
        //walletpassphrasechange

            Console.ReadKey();
        }
    }
}
