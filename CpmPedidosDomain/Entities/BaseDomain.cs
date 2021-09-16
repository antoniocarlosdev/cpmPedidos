using System;

namespace CpmPedidosDomain.Domain
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
