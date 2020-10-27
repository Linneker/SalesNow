using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Now.Domain.DTO.Product.Util
{
    public class TipoProduto : AbstractEntity
    {
        public TipoProduto(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
            Produtos = new HashSet<Produto>();
        }

        public string Nome { get; private set; }
        public string Descricao{ get; private set; }

        public virtual ICollection<Produto> Produtos { get; set; }

    }
}
