using QuickBuy.Dominio.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public DateTime DataPrevisaoEntrega  { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroDoEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public override void Validade()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem item de pedido!");

            if (String.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve estar preenchido!");

        }
    }
}
