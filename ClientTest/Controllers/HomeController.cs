using System;
using System.Web.Mvc;
using BitcoinWrapper.Data;
using BitcoinWrapper.Wrapper;
using BitcoinWrapper.Wrapper.Interfaces;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseBtcConnector _baseBtcConnector;
        private readonly IBitcoinService _bitcoinService;

        //
        // GET: /Home/
        public HomeController()
        {
            _baseBtcConnector =  new BaseBtcConnector(true);
            _bitcoinService = new BitcoinService(true);
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
            Block transaction = _baseBtcConnector.GetBlock(blockhashId);
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }
    }
}
