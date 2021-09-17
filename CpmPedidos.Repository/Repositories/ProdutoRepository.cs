using CpmPedidos.Interfaces;
using CpmPedidosDomain.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CpmPedidos.Repository
{
    public class ProdutoRepository : BaseRepository ,IProdutoRepository
    {
       
        public ProdutoRepository(ApplicationDbContext dbContext): base(dbContext)
        {
          
        }

        public List<Produto> Get()
        {
            return DbContext.Produtos
                .Where(x => x.Ativo)
                .OrderBy(x => x.Nome)
                .ToList();
            
        }

        public List<Produto> Search(string text)
        {
            return DbContext.Produtos
                .Where(x => x.Ativo && (x.Nome.ToUpper().Contains(text.ToUpper()) || x.Descricao.ToUpper().Contains(text.ToUpper())))
                .OrderBy(x => x.Nome)
                .ToList();

        }
    }
}
