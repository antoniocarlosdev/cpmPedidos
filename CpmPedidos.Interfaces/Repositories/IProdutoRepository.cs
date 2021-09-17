using CpmPedidosDomain.Domain;
using System.Collections.Generic;

namespace CpmPedidos.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> Get();
        List<Produto> Search(string text);
        Produto Detail(int id);
    }
}
