using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Digital_Core.Models
{
    public class Digital_CoreDb : DbContext
    {

        // criar o construtor
        public Digital_CoreDb() : base("Digital_CoreDbConnectionString")
        {

        }

        // definir as 'tabelas' da base de dados
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<TipoPagamento> TipoPagamento { get; set; }
        public virtual DbSet<ArtigoCompra> ArtigoCompra { get; set; }
        public virtual DbSet<Artigo> Artigo { get; set; }
        public virtual DbSet<TipoArtigo> TipoArtigo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}