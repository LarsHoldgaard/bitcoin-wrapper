using System;
using System.Configuration;
using System.Globalization;
using BitcoinWrapper.Wrapper;
using BitcoinWrapper.Wrapper.Interfaces;

namespace ConsoleClient
{
    internal sealed class Program
    {
        static void Main()
        {
            IBaseBtcConnector baseBtcConnector = new BaseBtcConnector("http://localhost:1920", "username", "password"); // Details could also be held in app.config and pulled in as string
            Console.Write("Connecting to bitcoin daemon: " + ConfigurationManager.AppSettings["ServerIp"] + "...");
            Double networkDifficulty = baseBtcConnector.GetDifficulty();
            Console.WriteLine("OK\n\nBTC Network Difficulty: " + networkDifficulty.ToString("#,#", CultureInfo.InvariantCulture));
            Decimal myBalance = baseBtcConnector.GetBalance();
            Console.WriteLine("My balance: " + myBalance + " BTC");
            Console.ReadLine();
        }
    }
}
