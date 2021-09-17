using CpmPedidosDomain.Domain;
using System.Collections.Generic;

namespace CpmPedidos.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> Get();
        List<Produto> Search(string text, int pagina);
        Produto Detail(int id);
    }
}
