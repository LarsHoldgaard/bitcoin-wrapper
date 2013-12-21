using System;
using BitcoinWrapper.Data;

namespace BitcoinWrapper.Wrapper
{
    /// <summary>
    /// This class is a helper class to get useful information
    /// </summary>
    public class BitcoinService
    {
        private readonly BaseBtcConnector _baseBtcConnector;

        public BitcoinService()
        {
            _baseBtcConnector = new BaseBtcConnector();    
        }

        public Transaction GetTransaction(String txId)
        {
            String rawTransaction = _baseBtcConnector.GetRawTransaction(txId);
            return _baseBtcConnector.DecodeRawTransaction(rawTransaction);
        }
    }
}
