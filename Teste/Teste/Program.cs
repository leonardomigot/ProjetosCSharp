using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste {
    class Program {
        static void Main( string[] args ) {
            //GravarDados();
            RecuperarProdutos();
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
