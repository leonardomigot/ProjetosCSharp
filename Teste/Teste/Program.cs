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

            prod.Nome = "jovemd";
            prod.Categoria = "cliented";
            prod.Preco = 738.98;

            using(var contexto = new ProdutoDAOEntity()) {
                contexto.Create( prod );
            }
        }
    }
}
