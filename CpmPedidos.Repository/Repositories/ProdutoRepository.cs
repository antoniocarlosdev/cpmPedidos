using CpmPedidos.Interfaces;
using CpmPedidosDomain.Domain;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CpmPedidos.Repository
{
    public class ProdutoRepository : BaseRepository , IProdutoRepository
    {
       
        public ProdutoRepository(ApplicationDbContext dbContext): base(dbContext)
        {
          
        }

        public dynamic Get()
        {
            return DbContext.Produtos
                .Include(x => x.Categoria)
                .Where(x => x.Ativo)
                .Select(x => new 
                { 
                    x.Nome,
                    x.Preco,
                    Categoria = x.Categoria.Nome,
                    Imagens = x.Imagens.Select(i => new
                    {
                        i.Id, //duvida
                        i.Nome,
                        i.NomeArquivo
                    })
                })
                .OrderBy(x => x.Nome)
                .ToList();
            
        }

        public dynamic Search(string text, int pagina)
        {
            var produtos = DbContext.Produtos
                .Include(x => x.Categoria)
                .Where(x => x.Ativo && (x.Nome.ToUpper().Contains(text.ToUpper()) || x.Descricao.ToUpper().Contains(text.ToUpper())))
                .Select(x => new {
                    x.Nome,
                    x.Preco,
                    Categoria = x.Categoria.Nome,
                    Imagens = x.Imagens.Select(i => new
                    {
                        i.Id, //duvida
                        i.Nome,
                        i.NomeArquivo
                    })
                })
                .Skip(TamanhoPagina * (pagina - 1))
                .Take(TamanhoPagina)
                .OrderBy(x => x.Nome)
                .ToList();
            var quantProdutos = DbContext.Produtos
                .Where(x => x.Ativo && (x.Nome.ToUpper().Contains(text.ToUpper()) || x.Descricao.ToUpper().Contains(text.ToUpper())))
                .Count();

            var quantPaginas = (quantProdutos / TamanhoPagina);
            if (quantPaginas < 1)
            {
                quantPaginas = 1;
            }

            return new { produtos, quantPaginas };

            
        }

        public dynamic Detail(int id)
        {
            return DbContext.Produtos
                .Include(x => x.Imagens)
                .Include(x => x.Categoria)
                .Where(x => x.Ativo && x.Id == id)
                .Select(x => new 
                { 
                    x.Id,
                    x.Nome,
                    x.Codigo,
                    x.Descricao,
                    x.Preco,
                    Categoria = new  //duvida
                    {
                        x.Categoria.Id,
                        x.Categoria.Nome

                    },
                    Imagens = x.Imagens.Select(i => new 
                    {
                        i.Id, //duvida
                        i.Nome,
                        i.NomeArquivo
                    })

                })
                .FirstOrDefault();
        }

        public dynamic Imagens(int id)
        {
            return DbContext.Produtos
                .Include(x => x.Imagens)
                .Where(x => x.Ativo && x.Id == id)
                .SelectMany(x => x.Imagens, (produto, imagem) => new
                {
                    IdProduto = produto.Id,
                    imagem.Id,
                    imagem.Nome,
                    imagem.NomeArquivo
                })
                .FirstOrDefault();
        }
    }
}
