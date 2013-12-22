using System;
using BitcoinWrapper.Data;
using BitcoinWrapper.Wrapper.Interfaces;

namespace BitcoinWrapper.Wrapper
{
    /// <summary>
    /// This class is a helper class to get useful information
    /// </summary>
    public sealed class BitcoinService : IBitcoinService
    {
        private readonly IBaseBtcConnector _baseBtcConnector;

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
