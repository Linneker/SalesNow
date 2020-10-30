using Sales.Now.Domain.DTO.Product;
using Sales.Now.Domain.Interfaces.Repository.Product;
using Sales.Now.Domain.Interfaces.Services.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Now.Domain.Services.Product
{
    public class ProdutoServices : ServicesBase<Produto>, IProdutoServices
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoServices(IProdutoRepository produtoRepository):base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> GetBetweenDataVendaAndDataCompra(DateTime dataVenda, DateTime dataCompra)
        {
            return _produtoRepository.GetBetweenDataVendaAndDataCompra(dataVenda, dataCompra);
        }

        public Task<List<Produto>> GetBetweenDataVendaAndDataCompraAsync(DateTime dataVenda, DateTime dataCompra)
        {
            return _produtoRepository.GetBetweenDataVendaAndDataCompraAsync(dataVenda, dataCompra);
        }

        public List<Produto> GetBetweenDataVendaInicialAndDataVendaFinal(DateTime dataVendaInicial, DateTime dataVendaFinal)
        {
            return _produtoRepository.GetBetweenDataVendaInicialAndDataVendaFinal(dataVendaInicial, dataVendaFinal);
        }

        public Task<List<Produto>> GetBetweenDataVendaInicialAndDataVendaFinalAsync(DateTime dataVendaInicial, DateTime dataVendaFinal)
        {
            return _produtoRepository.GetBetweenDataVendaInicialAndDataVendaFinalAsync(dataVendaInicial, dataVendaFinal);
        }

        public Produto GetByCodigo(long codigo)
        {
            return _produtoRepository.GetByCodigo(codigo);
        }

        public Task<Produto> GetByCodigoAsync(long codigo)
        {
            return _produtoRepository.GetByCodigoAsync(codigo);
        }

        public List<Produto> GetByDataCompra(DateTime dataCompra)
        {
            return _produtoRepository.GetByDataCompra(dataCompra);
        }

        public Task<List<Produto>> GetByDataCompraAsync(DateTime dataCompra)
        {
            return _produtoRepository.GetByDataCompraAsync(dataCompra);
        }

        public List<Produto> GetByDataVenda(DateTime dataVenda)
        {
            return _produtoRepository.GetByDataVenda(dataVenda);
        }

        public Task<List<Produto>> GetByDataVendaAsync(DateTime dataVenda)
        {
            return _produtoRepository.GetByDataVendaAsync(dataVenda);
        }
    }
}
