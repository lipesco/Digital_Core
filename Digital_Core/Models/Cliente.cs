using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Digital_Core.Models
{
    public class Cliente
    {
        public Cliente()
        {
            // inicialização da lista de compras de um cliente
            ListaCompras = new HashSet<Compra>();
        }

        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        [Required]
        [StringLength(15)]
        public string username { get; set; }

        [Required]
        [StringLength(20)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string morada { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        public int telefone { get; set; }

        public int NIF { get; set; }

        // um cliente tem uma coleção de compras
        public virtual ICollection<Compra> ListaCompras { get; set; }



    }
}
