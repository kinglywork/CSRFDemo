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
            return Content($"Transfer {transferModel.Amount} to {transferModel.TargetAccount} success!");
        }
	}
}