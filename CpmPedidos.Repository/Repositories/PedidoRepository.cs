using CpmPedidos.Interfaces;
using CpmPedidosDomain.Domain;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace CpmPedidos.Repository
{
    public class PedidoRepository : BaseRepository , IPedidoRepository
    {
       
        public PedidoRepository(ApplicationDbContext dbContext): base(dbContext)
        {
          
        }

        public decimal TicketMaximo()
        {
            var hoje = DateTime.Today;

            return DbContext.Pedidos
                .Where(x => x.CriadoEm.Date == hoje)
                .Max(x => (decimal?)x.ValorTotal) ?? 0;
            
        }
    }
}
