using System;
using System.Web.Mvc;
using BitcoinWrapper.Data;
using BitcoinWrapper.Wrapper;

namespace ClientTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly BaseBtcConnector _baseBtcConnector;
        private readonly BitcoinService _bitcoinService;

        //
        // GET: /Home/
        public HomeController()
        {
            _baseBtcConnector =  new BaseBtcConnector();
            _bitcoinService = new BitcoinService();
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public Decimal GetBalanceInWallet()
        {
            return _baseBtcConnector.GetBalance();
        }

        [HttpGet]
        public JsonResult GetInformationAboutTransaction(String txId)
        {
            Transaction transaction = _bitcoinService.GetTransaction(txId);
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetBlockInfo(String blockhashId)
        {
            var transaction = _baseBtcConnector.GetBlock(blockhashId);
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }
    }
}
