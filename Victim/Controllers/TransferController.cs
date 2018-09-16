using System.Threading.Tasks;
using System.Web.Mvc;
using Victim.Models;

namespace Victim.Controllers
{
    [Authorize]
    public class TransferController : Controller
    {
        //
        // GET: /Transfer/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Money(TransferModel transferModel)
        {
            return Content(string.Format("Transfer {0} to {1} success!", transferModel.Amount, transferModel.TargetAccount));
        }
	}
}