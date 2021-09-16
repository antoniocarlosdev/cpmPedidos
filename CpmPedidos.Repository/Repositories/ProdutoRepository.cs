using CpmPedidos.Interfaces;
using CpmPedidosDomain.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CpmPedidos.Repository.Repositories
{
    public class ProdutoRepository : BaseRepository ,IProdutoRepository
    {
       
        public ProdutoRepository(ApplicationDbContext dbContext): base(dbContext)
        {
          
        }

        public List<Produto> Get()
        {
            return DbContext.Produtos.ToList();
        }
    }
}
