using CpmPedidosDomain.Domain;
using System.Collections.Generic;

namespace CpmPedidos.Interfaces
{
    public interface IProdutoRepository
    {
        dynamic Get(string ordem);
        dynamic Search(string text, int pagina, string ordem);
        dynamic Detail(int id);
        public dynamic Imagens(int id);
    }
}
