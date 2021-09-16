using CpmPedidosDomain.Domain;
using System.Collections.Generic;

namespace CpmPedidos.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> Get();
    }
}
