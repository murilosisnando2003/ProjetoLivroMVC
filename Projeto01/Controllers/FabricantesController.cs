using System.Linq;
using System.Web.Mvc;
using Projeto01.Contexts;

namespace Projeto01.Controllers
{
    public class FabricantesController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c=>c.Nome));
        }
    }
}