using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Cadastros;
using Persistencia.DAL.Tabelas;
using System.Linq;
using Modelo.Tabelas;

namespace Servico.Tabelas
{
    public class CategoriaServico
    {
        private CategoriaDAL categoriaDAL = new CategoriaDAL();

        public IQueryable<Categoria>ObterCategoriasClassificadasPorNome()
        {
            return categoriaDAL.ObterCategoriasClassificadasPorNome();
        }
    }
}
