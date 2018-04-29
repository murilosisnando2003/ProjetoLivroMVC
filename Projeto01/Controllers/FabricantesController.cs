using System.Linq;
using System.Net;
using System.Web.Mvc;
using Modelo.Cadastros;
using Servico.Cadastros;
using Servico.Tabelas;

namespace Persistencia.Controllers
{
    public class FabricantesController : Controller
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        private CategoriaServico categoriaServico = new CategoriaServico();
        private FabricanteServico fabricanteServico = new FabricanteServico();


        private ActionResult ObterVisaoFabricantePorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = fabricanteServico.ObterFabricantePorId((long)id);
            if (fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        private void PopularViewBag(Fabricante fabricante = null)
        {
            if (fabricante == null)
            {
                ViewBag.CategoriaId = new SelectList(categoriaServico.ObterCategoriasClassificadasPorNome(), "CategoriaId", "Nome");
                ViewBag.FabricanteId = new SelectList(fabricanteServico.ObterFabricantesClassificacosPorNome(), "FabricanteId", "Nome");
            }
            else
            {
                ViewBag.CategoriaId = new SelectList(categoriaServico.ObterCategoriasClassificadasPorNome(), "CategoriaId", "Nome", fabricante.FabricanteId);
                ViewBag.FabricanteId = new SelectList(fabricanteServico.ObterFabricantesClassificacosPorNome(), "FabricanteId", "Nome",fabricante.FabricanteId);
            }
        }

        private ActionResult GravarFabricante(Fabricante fabricante)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    fabricanteServico.GravarFabricante(fabricante);
                    return RedirectToAction("Index");
                }
                return View(fabricante);
            }
            catch
            {
                return View(fabricante);

            }
        }



        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(fabricanteServico.ObterFabricantesClassificacosPorNome());
        }


        //Create: Fabricantes
        public ActionResult Create()
        {
            PopularViewBag();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fabricante)
        {
            return GravarFabricante(fabricante);
        }

        //GET: Fabricante/Edit/5
        public ActionResult Edit(long? id)
        {
            PopularViewBag(fabricanteServico.ObterFabricantePorId((long)id));
            return ObterVisaoFabricantePorId(id);
        }

        //POST: Fabricante
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fabricante fabricante)
        {
            return GravarFabricante(fabricante);
        }
        //GET: Fabricante/Details/5
        public ActionResult Details(long? id)
        {
            return ObterVisaoFabricantePorId(id);
        }

        //GET: Fabricante/Details/5
        public ActionResult Delete(long? id)
        {
            return ObterVisaoFabricantePorId(id);
        }
        //POST: Fabricantes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            try
            {
                Fabricante fabricante = fabricanteServico.EliminarFabricantePorId(id);
                TempData["Message"] = "Fabricante " + fabricante.Nome.ToUpper() + " foi removido";
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

    }
}