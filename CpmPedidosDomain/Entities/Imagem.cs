using CpmPedidosDomain.Entities;

namespace CpmPedidosDomain.Domain
{
    public class Imagem: BaseDomain
    {
     
        public string Nome { get; set; }
        public string NomeArquivo { get; set; }
        public bool Principal { get; set; }
    }
}
