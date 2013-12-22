using System;
using System.Collections.Generic;
using BitcoinWrapper.Common;
using BitcoinWrapper.Data;

namespace BitcoinWrapper.Wrapper
{
    /// <summary>
    /// This connector implements all the original methods in the Bitcoin-qt API
    /// See more here: https://en.bitcoin.it/wiki/Original_Bitcoin_client/API_Calls_list
    /// </summary>
    public class BaseBtcConnector
    {
        public BaseConnector BaseConnector { get; set; }

        /// <summary>
        /// Starts connecting to the Bitcoin-qt server
        /// </summary>
        public BaseBtcConnector()
        {
            BaseConnector = new BaseConnector();
        }

        public Decimal GetBalance()
        {
            var result = BaseConnector.RequestServer(MethodName.getbalance)["result"].ToString();
            Decimal balance;
            Decimal.TryParse(result, out balance);
            return balance;
        }

        public Block GetBlock(String hash)
        {
            return BaseConnector.RequestServer(MethodName.getblock, hash)["result"].ToObject<Block>();
        }

        public String GetRawTransaction(String txId)
        {
            return BaseConnector.RequestServer(MethodName.getrawtransaction, txId)["result"].ToString();
        }

        public Transaction DecodeRawTransaction(String rawTransaction)
        {
            return BaseConnector.RequestServer(MethodName.decoderawtransaction, rawTransaction)["result"].ToObject<Transaction>();
        }
        
        public String GetAccount(String bitcoinAddress)
        {
            return BaseConnector.RequestServer(MethodName.getaccount, bitcoinAddress)["result"].ToString();
        }

        public Int32 GetBlockCount()
        {
            String result = BaseConnector.RequestServer(MethodName.getblockcount)["result"].ToString();
            Int32 balance;
            Int32.TryParse(result, out balance);
            return balance;
        }

        public String GetBlockhash(Int32 index)
        {
            return BaseConnector.RequestServer(MethodName.getblockhash, index)["result"].ToString();
        }

        public Double GetDifficulty()
        {
            String result = BaseConnector.RequestServer(MethodName.getdifficulty)["result"].ToString();
            Double balance;
            Double.TryParse(result, out balance);
            return balance;
        }

        public String GetGenerate()
        {
            return BaseConnector.RequestServer(MethodName.getgenerate)["result"].ToString();
        }

        public Int32 GetHashesPerSec()
        {
            String result = BaseConnector.RequestServer(MethodName.gethashespersec)["result"].ToString();
            Int32 balance;
            Int32.TryParse(result, out balance);
            return balance;
        }

        public String GetInfo()
        {
            return BaseConnector.RequestServer(MethodName.getinfo)["result"].ToString();
        }

        public String GetMiningInfo()
        {
            return BaseConnector.RequestServer(MethodName.getmininginfo)["result"].ToString();
        }

        public String GetPeerInfo()
        {
            return BaseConnector.RequestServer(MethodName.getpeerinfo)["result"].ToString();
        }

        public String GetRawMemPool()
        {
            return BaseConnector.RequestServer(MethodName.getrawmempool)["result"].ToString();
        }

        public String BackupWallet(String destination)
        {
            return BaseConnector.RequestServer(MethodName.backupwallet, destination)["result"].ToString();
        }

        public String DumpPrivKey(String bitcoinAddress)
        {
            return BaseConnector.RequestServer(MethodName.dumpprivkey, bitcoinAddress)["result"].ToString();
        }

        public String EncryptWallet(String passphrame)
        {
            return BaseConnector.RequestServer(MethodName.encryptwallet, passphrame)["result"].ToString();
        }

        public String GetAccountAddress(String account)
        {
            return BaseConnector.RequestServer(MethodName.getaccountaddress, account)["result"].ToString();
        }

        public String GetAddressesByAccount(String account)
        {
            return BaseConnector.RequestServer(MethodName.getaddressesbyaccount, account)["result"].ToString();
        }

        public String GetBlockTemplate()
        {
            return BaseConnector.RequestServer(MethodName.getblocktemplate)["result"].ToString();
        }

        public Int32 GetconnectionCount()
        {
            String rawTransaction = BaseConnector.RequestServer(MethodName.getconnectioncount)["result"].ToString();
            Int32 count;
            Int32.TryParse(rawTransaction, out count);
            return count;
        }

        public String GetNewAddress(String account)
        {
            return BaseConnector.RequestServer(MethodName.getnewaddress, account)["result"].ToString();
        }

        public String GetReceivedByAccount(String account)
        {
            return BaseConnector.RequestServer(MethodName.getreceivedbyaccount, account)["result"].ToString();
        }

        public String GetReceivedByAddress(String bitcoinAddress)
        {
            return BaseConnector.RequestServer(MethodName.getreceivedbyaddress, bitcoinAddress)["result"].ToString();
        }

        /// <summary>
        /// Only for in-wallet transactions. To find "all transactions", use GetRawTransaction and decude with DecodeRawTransaction
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        public InwalletTransaction GetTransaction(String txid)
        {
            return BaseConnector.RequestServer(MethodName.gettransaction, txid)["result"].ToObject<InwalletTransaction>();
        }

        public String GetWork()
        {
            return BaseConnector.RequestServer(MethodName.getwork)["result"].ToString();
        }

        public String Help()
        {
            return BaseConnector.RequestServer(MethodName.help)["result"].ToString();
        }

        public String ListAccounts()
        {
            return BaseConnector.RequestServer(MethodName.listaccounts)["result"].ToString();
        }

        public String ListAddressGroupings()
        {
            return BaseConnector.RequestServer(MethodName.listaddressgroupings)["result"].ToString();
        }

        public String ListReceivedByAccount()
        {
            return BaseConnector.RequestServer(MethodName.listreceivedbyaccount)["result"].ToString();
        }

        public String ListReceivedByAddress()
        {
            return BaseConnector.RequestServer(MethodName.listreceivedbyaddress)["result"].ToString();
        }

        public String ListSinceBlock()
        {
            return BaseConnector.RequestServer(MethodName.listsinceblock)["result"].ToString();
        }

        public String ListTransactions()
        {
            return BaseConnector.RequestServer(MethodName.listtransactions)["result"].ToString();
        }

        public String ListLockUnspent()
        {
            return BaseConnector.RequestServer(MethodName.listlockunspent)["result"].ToString();
        }

        public String SetTxFee(Decimal amount)
        {
            return BaseConnector.RequestServer(MethodName.settxfee, amount)["result"].ToString();
        }

        public String WalletLock()
        {
            return BaseConnector.RequestServer(MethodName.walletlock)["result"].ToString();
        }

        public String ValidateAddress(String bitcoinAddress)
        {
            return BaseConnector.RequestServer(MethodName.validateaddress, bitcoinAddress)["result"].ToString();
        }

        public String Stop()
        {
            return BaseConnector.RequestServer(MethodName.stop)["result"].ToString();
        }

        public String SetGenerate(Boolean variable)
        {
            return BaseConnector.RequestServer(MethodName.setgenerate, variable)["result"].ToString();
        }
        
        /// <summary>
        /// not tested
        /// </summary>
        /// <param name="bitcoinAddress"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public String SendToAddress(String bitcoinAddress, Decimal amount)
        {
            return BaseConnector.RequestServer(MethodName.sendtoaddress, new List<object> { bitcoinAddress, amount })["result"].ToString();
        }

        public String SendRawTransaction(String rawTrans)
        {
            return BaseConnector.RequestServer(MethodName.sendrawtransaction, rawTrans)["result"].ToString();
        }

        public String AddNode(String node, NodeAction action)
        {
            return BaseConnector.RequestServer(MethodName.addnode, new List<object> { node, action.ToString() })["result"].ToString();
        }

        public String GetAddedNodeInfo(String dns)
        {
            return BaseConnector.RequestServer(MethodName.getaddednodeinfo, dns)["result"].ToString();
        }

        public String GetTxOut(String txId, Int32 n)
        {
            return BaseConnector.RequestServer(MethodName.gettxout, new List<object> { txId, n })["result"].ToString();
        }

        public String GetTxOutSetInfo()
        {
            return BaseConnector.RequestServer(MethodName.gettxoutsetinfo)["result"].ToString();
        }

        public String KeyPoolRefill()
        {
            return BaseConnector.RequestServer(MethodName.keypoolrefill)["result"].ToString();
        }

        public String SendFrom(String fromAccount, String toBitcoinAddress, Decimal amount)
        {
            return BaseConnector.RequestServer(MethodName.sendfrom, new List<object> { fromAccount, toBitcoinAddress, amount })["result"].ToString();
        }

        public String SignMessage(String bitcoinAddress, String message)
        {
            return BaseConnector.RequestServer(MethodName.signmessage, new List<object> { bitcoinAddress, message })["result"].ToString();
        }

        public String SubmitBlock(String hexData)
        {
            return BaseConnector.RequestServer(MethodName.submitblock, hexData)["result"].ToString();
        }

        public String VerifyMessage(String bitcoinAddress, String signature, String message)
        {
            return BaseConnector.RequestServer(MethodName.verifymessage, new List<object> { bitcoinAddress, signature, message })["result"].ToString();
        }

        /// <summary>
        /// This opens the Bitcoin wallet to access methods which requires an open wallet
        /// </summary>
        /// <param name="passphrase">Password you've encrypted the wallet with</param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public String WalletPassphrase(String passphrase, Int32 timeout)
        {
            return BaseConnector.RequestServer(MethodName.walletpassphrase, new List<object> { passphrase,timeout })["result"].ToString();
        }

        public String WalletPassphraseChange(String oldPassphrase, String newPassphrase)
        {
            return BaseConnector.RequestServer(MethodName.walletpassphrasechange, new List<object> { oldPassphrase, newPassphrase })["result"].ToString();
        }

        public String Move(String fromAccount, String toAccount, Decimal amount)
        {
            return BaseConnector.RequestServer(MethodName.move, new List<object> { fromAccount , toAccount, amount })["result"].ToString();
        }
    }
}
