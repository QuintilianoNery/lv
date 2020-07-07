using System.Collections.Generic;
using System.Linq;

namespace PooLojaVirtual.Models
{
    public class Carrinho : Entidade
    {
        public List<ItemCarrinho> Itens { get; set; } = new List<ItemCarrinho>();

        public double Total
        {
            get
            {
                return Itens.Sum(item => item.Produto.Preco);
            }
        }

        public void Adicionar(Produto produto, int quantidade)
        {
            Itens.Add(new ItemCarrinho(produto, quantidade));
        }

        public void Remover(int idProduto)
        {
            var itemNoCarrinho = Itens.FirstOrDefault(item => item.Produto.Id == idProduto);
            if (itemNoCarrinho != null)
            {
                Itens.Remove(itemNoCarrinho);
            }
        }
    }
}