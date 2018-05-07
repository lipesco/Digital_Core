namespace Digital_Core.Migrations
{
    using Digital_Core.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Digital_Core.Models.Digital_CoreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Digital_Core.Models.Digital_CoreDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //*********************************************************************
            // adiciona Clientes
            var cliente = new List<Cliente> {
                new Cliente {ID=1, nome="Miguel Vitor", username="mvitor", password="123", morada="Rua do Comércio, Nº18", email="mvitor@gmail.com", telefone=249123456, NIF=115347923 },
                new Cliente {ID=2, nome="Pedro Conceição", username="pconceicaor", password="213", morada="Rua João Torres, Nº94", email="pconceicao@yahoo.com", telefone=249765638, NIF=115836783 },
                new Cliente {ID=3, nome="Maria Isabel", username="misabel", password="321", morada="Praça do Bom Jardim, Nº25", email="misabel@sapo.pt", telefone=249654321, NIF=102385734 },
                new Cliente {ID=4, nome="João Silva", username="jsilva", password="132", morada="Rua da Alcântara, Nº142", email="jsilva@gmail.pt", telefone=249538247, NIF=201482693 },
                new Cliente {ID=5, nome="Teresa Pinheiro", username="tpinheiro", password="312", morada="Rua D. Pedro, Nº11", email="tpinheiro@hotmail.com", telefone=249823953, NIF=159385395 },
                new Cliente {ID=6, nome="Marta Santos", username="msantos", password="231", morada="Rua Oliveira Gaio, Nº275", email="msantos@sapo.pt", telefone=249839258, NIF=128573957 }
            };
            cliente.ForEach(CL => context.Cliente.AddOrUpdate(cl => cl.nome, CL));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Tipo de Artigos
            var tipoArtigo = new List<TipoArtigo> {
                new TipoArtigo {ID=1, descricao="Computador Desktop"},
                new TipoArtigo {ID=2, descricao="Monitor"},
                new TipoArtigo {ID=3, descricao="Portátil"},
                new TipoArtigo {ID=4, descricao="Tablet"},
                new TipoArtigo {ID=5, descricao="Disco"},
                new TipoArtigo {ID=6, descricao="Memória RAM"},
                new TipoArtigo {ID=7, descricao="Placa Gráfica"},
                new TipoArtigo {ID=8, descricao="Impressora"},
                new TipoArtigo {ID=9, descricao="Pen USB"},
                new TipoArtigo {ID=10, descricao="Rato"},
                new TipoArtigo {ID=11, descricao="Teclado"}


            };
            tipoArtigo.ForEach(TAR => context.TipoArtigo.AddOrUpdate(tar => tar.descricao, TAR));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Artigos
            var artigo = new List<Artigo> {
                new Artigo {ID=1, numeroSerie=123456789, TipoFK=1, descricao="HP Omen 880-106Np", caracteristicas="Processador Intel i7 8700, RAM 16GB", preco="€1200", imagem="computador01.jpg" },
                new Artigo {ID=2, numeroSerie=123456790, TipoFK=5, descricao="Toshiba TR200 3D TLC SATA III", caracteristicas="Disco SSD 240GB", preco="€55", imagem="discossd01.jpg" },
                new Artigo {ID=3, numeroSerie=123456791, TipoFK=1, descricao="Asus ROG GR8II-T022Z Auta", caracteristicas="Processador Intel i5 7400, RAM 9GB", preco="€950", imagem="computador02.jpg" },
                new Artigo {ID=4, numeroSerie=123456792, TipoFK=1, descricao="Asus D320MT", caracteristicas="Processador Intel i7 7700, RAM 8GB", preco="€600", imagem="computador03.jpg" },
                new Artigo {ID=5, numeroSerie=123456793, TipoFK=5, descricao="Samsung 500GB EVO 850", caracteristicas="Disco SSD 500GB", preco="€125", imagem="discossd02.jpg" },
                new Artigo {ID=6, numeroSerie=123456794, TipoFK=5, descricao="Kingston 120GB SSD A400 SATA III", caracteristicas="Disco SSD 120GB", preco="€35", imagem="discossd03.jpg" },
                new Artigo {ID=7, numeroSerie=123456795, TipoFK=3, descricao="HP 15-bs109np", caracteristicas="Processador Intel i5 8250U, RAM 8GB, Disco 1TB", preco="€550", imagem="portatil01.jpg" },
                new Artigo {ID=8, numeroSerie=123456796, TipoFK=3, descricao="Asus Zenbook UX430UA-78DHDCB1", caracteristicas="Processador Intel i7-8550U, 16GB RAM, Disco SSD 512GB", preco="€55", imagem="portatil02.jpg" }

            };
            artigo.ForEach(PR => context.Artigo.AddOrUpdate(pr => pr.numeroSerie, PR));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Tipo de Pagamentos
            var tipoPagamento = new List<TipoPagamento> {
                new TipoPagamento {ID=1, descricao="Cartão de Crédito"},
                new TipoPagamento {ID=2, descricao="Referência Multibanco"},
                new TipoPagamento {ID=3, descricao="Paypal"},
                new TipoPagamento {ID=4, descricao="PayShop"}
            };
            tipoPagamento.ForEach(TPC => context.TipoPagamento.AddOrUpdate(tpc => tpc.descricao, TPC));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Compras
            var compra = new List<Compra> {
                new Compra {ID=1, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=1, PagamentoFK=1 },
                new Compra {ID=2, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=3, PagamentoFK=2 },
                new Compra {ID=3, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=6, PagamentoFK=1 },
                new Compra {ID=4, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=1, PagamentoFK=1 },
                new Compra {ID=5, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=2, PagamentoFK=1 },
                new Compra {ID=6, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=5, PagamentoFK=3 },
                new Compra {ID=7, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=2, PagamentoFK=1 },
                new Compra {ID=8, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=4, PagamentoFK=1 },
                new Compra {ID=9, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=5, PagamentoFK=3 },
                new Compra {ID=10, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=3, PagamentoFK=2 },
                new Compra {ID=11, dataCompra=new DateTime(2018,05,07), dataEntrega=new DateTime(2018,05,08), ClienteFK=3, PagamentoFK=2 }

            };
            compra.ForEach(C => context.Compra.AddOrUpdate(c => c.dataCompra, C));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Relação Compras & Artigo
            var artigoCompra = new List<ArtigoCompra> {
                new ArtigoCompra {ID=1, IDProd=1, IDCompr=1, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=2, IDProd=4, IDCompr=2, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=3, IDProd=8, IDCompr=3, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=4, IDProd=3, IDCompr=4, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=5, IDProd=1, IDCompr=5, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=6, IDProd=5, IDCompr=6, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=7, IDProd=6, IDCompr=7, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=8, IDProd=2, IDCompr=8, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=9, IDProd=7, IDCompr=9, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=10, IDProd=1, IDCompr=10, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=11, IDProd=3, IDCompr=11, quantidade=1, IVA="23" }
            };
            artigoCompra.ForEach(PC => context.ArtigoCompra.AddOrUpdate(pc => pc.IDProd, PC));
            context.SaveChanges();

        }
    }
}
