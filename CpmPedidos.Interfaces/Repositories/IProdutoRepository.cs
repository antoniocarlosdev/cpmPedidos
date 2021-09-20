using CpmPedidosDomain.Domain;
using System.Collections.Generic;

namespace CpmPedidos.Interfaces
{
    public interface IProdutoRepository
    {
        dynamic Get();
        dynamic Search(string text, int pagina);
        dynamic Detail(int id);
        public dynamic Imagens(int id);
    }
}
