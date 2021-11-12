using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste {
    class Program {
        static void Main( string[] args ) {
            //GravarDados();
            //RecuperarProdutos();
            //DeletarProduto();
            RecuperarProdutos();
            UpdateProduto();   
            RecuperarProdutos();    
        }

        private static void UpdateProduto()
        {
            
            using (var repo = new LojaContext())
            {
                Produto primeiro = repo.Produtos.First();

                primeiro.Nome = "novonome";

                repo.Produtos.Update(primeiro);
                repo.SaveChanges(); 


            }
            
        }

        private static void DeletarProduto()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item); 
                }
                repo.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarDados() {
            Produto prod = new Produto();

            prod.Nome = "jovemd";
            prod.Categoria = "cliented";
            prod.Preco = 738.98;

            using(var contexto = new LojaContext()) {
                contexto.Produtos.Add( prod );
                contexto.SaveChanges();
            }
        }
    }
}
