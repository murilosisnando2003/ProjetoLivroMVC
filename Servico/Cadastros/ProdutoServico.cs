using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Cadastros;
using Persistencia.DAL.Cadastros;
using System.Linq;

namespace Servico.Cadastros
{
    public class ProdutoServico
    {
        private ProdutoDAL produtoDAL = new ProdutoDAL();

        public IQueryable ObterProdutosClassificadosPorNome()
        {
            return produtoDAL.ObterProdutosClassificadosPorNome();
        }
        public Produto ObterProdutosPorId(long id)
        {
            return produtoDAL.ObterProdutosPorId(id);
        }
        public void GravarProduto(Produto produto)
        {
            produtoDAL.GravarProduto(produto);
        }
        public Produto EliminarProdutoPorId(long id)
        {
            return produtoDAL.EliminarProdutoPorId(id);
        }
    }
}
