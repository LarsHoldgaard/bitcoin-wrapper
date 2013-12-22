using System;
using BitcoinWrapper.Data;

namespace BitcoinWrapper.Wrapper.Interfaces
{
    public interface IBitcoinService
    {
        Transaction GetTransaction(String txId);
    }
}