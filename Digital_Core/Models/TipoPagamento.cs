using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Digital_Core.Models
{
    public class TipoPagamento
    {
        public TipoPagamento()
        {
            // inicialização da lista de compras de um tipo
            ListaTipoPagamento = new HashSet<Compra>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string descricao { get; set; }

        // um TipoPagamento tem uma coleção de compras
        public virtual ICollection<Compra> ListaTipoPagamento { get; set; }

    }
