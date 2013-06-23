using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitcoinWrapper.Data;

namespace BitcoinWrapper.Wrapper
{
    /// <summary>
    /// This class is a helper class to get useful information
    /// </summary>
    public class BitcoinService
    {
        private BaseBtcConnector _baseBtcConnector;

        public BitcoinService()
        {
            this._baseBtcConnector = new BaseBtcConnector();    
        }

        public Transaction GetTransaction(string txid)
        {
            var rawTransaction = _baseBtcConnector.GetRawTransaction(txid);
            var infoAboutTransaction = _baseBtcConnector.DecodeRawTransaction(rawTransaction);
            return infoAboutTransaction;
        }

    }
}
