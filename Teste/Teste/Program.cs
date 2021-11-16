using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Teste {
    class Program {
        static void Main( string[] args ) {


            using (var contexto = new LojaContext())
            {

                var produtos = contexto.Produtos.ToList();

                //var novoProd = new Produto()
                //{
                //    Nome = "jovem",
                //    Categoria = "style",
                //    Preco = 5
                //};

                var p1 = produtos.First();  

                contexto.Produtos.Remove( p1 );

                contexto.SaveChanges();



                ShowEnt(contexto.ChangeTracker.Entries());

                

            }
        }

        private static void ShowEnt(IEnumerable<EntityEntry> entries)
        {            
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + e.State);
            }
        }

        private static void UpdateProduto()
        {
            
            using (var repo = new ProdutoDAOEntity())
            {
                Produto primeiro = repo.GetAll().First();

                primeiro.Nome = "novonome";

                repo.Update(primeiro);


            }
            
        }

        private static void DeletarProduto()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.GetAll();
                foreach (var item in produtos)
                {
                    repo.Delete(item); 
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.GetAll();
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarDados() {
            Produto prod = new Produto();

            prod.Nome = "segundo";
            prod.Categoria = "cliented";
            prod.Preco = 738.98;

            using(var contexto = new ProdutoDAOEntity()) {
                contexto.Create( prod );
            }
        }
    }
}
