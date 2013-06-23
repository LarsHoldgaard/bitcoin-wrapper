using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitcoinWrapper.Wrapper;

namespace ClientTest.Controllers
{
    public class HomeController : Controller
    {
        private BaseBtcConnector _baseBtcConnector;
        private BitcoinService _bitcoinService;

        //
        // GET: /Home/

        public HomeController()
        {
            this._baseBtcConnector =  new BaseBtcConnector();
            this._bitcoinService = new BitcoinService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public float GetBalanceInWallet()
        {
            var balance = _baseBtcConnector.GetBalance();
            return balance;
        }

        [HttpGet]
        public JsonResult GetInformationAboutTransaction(string txid)
        {
            var transaction = _bitcoinService.GetTransaction(txid);
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetBlockInfo(string blockhashId)
        {
            var transaction = _baseBtcConnector.GetBlock(blockhashId);
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }
    }
}
