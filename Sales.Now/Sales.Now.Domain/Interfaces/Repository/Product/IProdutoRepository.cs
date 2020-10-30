using Sales.Now.Domain.DTO.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Now.Domain.Interfaces.Repository.Product
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        Produto GetByCodigo(long codigo);
        Task<Produto> GetByCodigoAsync(long codigo);

        List<Produto> GetByDataVenda(DateTime dataVenda);
        Task<List<Produto>> GetByDataVendaAsync(DateTime dataVenda);

        List<Produto> GetByDataCompra(DateTime dataCompra);
        Task<List<Produto>> GetByDataCompraAsync(DateTime dataCompra);

        List<Produto> GetBetweenDataVendaAndDataCompra(DateTime dataVenda, DateTime dataCompra);
        Task<List<Produto>> GetBetweenDataVendaAndDataCompraAsync(DateTime dataVenda, DateTime dataCompra);

        List<Produto> GetBetweenDataVendaInicialAndDataVendaFinal(DateTime dataVendaInicial, DateTime dataVendaFinal);
        Task<List<Produto>> GetBetweenDataVendaInicialAndDataVendaFinalAsync(DateTime dataVendaInicial, DateTime dataVendaFinal);

    }
}
