using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Digital_Core.Models
{
    public class ArtigoCompra
    {
        public int ID { get; set; } // PK, por exigência da Entity Framework

        // atributos específicos do relacionamento
        public int IDArtigo { get; set; }
        public int IDCompra { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Artigo
        //***********************************************************************
        [ForeignKey("IDProd")]
        public Artigo Artigo { get; set; }
        public int IDProd { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Compra
        //***********************************************************************
        [ForeignKey("IDCompr")]
        public Compra Compra { get; set; }
        public int IDCompr { get; set; }

        //***********************************************************************

        public int quantidade { get; set; }

        public string IVA { get; set; }
    }
}