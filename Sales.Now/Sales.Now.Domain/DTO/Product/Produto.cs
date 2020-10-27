using Sales.Now.Domain.DTO.Product.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Now.Domain.DTO.Product
{
    public class Produto : AbstractEntity
    {
        public Produto(string nome, string descricao, decimal valorCompra, decimal valorVenda, int quantidade, DateTime dataCompra, DateTime dataVenda, DateTime? vencimento, Guid tipoProdutoId)
        {
            Nome = nome;
            Descricao = descricao;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            DataVenda = dataVenda;
            Vencimento = vencimento;
            TipoProdutoId = tipoProdutoId;
        }

        public Produto(string nome, string descricao, decimal valorCompra, decimal valorVenda, int quantidade, DateTime dataCompra, DateTime dataVenda, DateTime? vencimento, TipoProduto tipoProduto)
        {
            Nome = nome;
            Descricao = descricao;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            DataVenda = dataVenda;
            Vencimento = vencimento;
            TipoProduto = tipoProduto;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal ValorCompra { get; private set; }
        public decimal ValorVenda { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime DataCompra { get; private set; }
        public DateTime DataVenda { get; private set; }
        public DateTime? Vencimento { get; private set; }

        public Guid TipoProdutoId { get; private set; }

        public virtual TipoProduto TipoProduto{ get;  set; }
    
    }

}
