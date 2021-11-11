using System;

namespace Teste {
    class Program {
        static void Main( string[] args ) {
            GravarDados();
        }

        private static void GravarDados() {
            Produto prod = new Produto();

            prod.Nome = "jovem";
            prod.Categoria = "cliente";
            prod.Preco = 78.98;

            using(var contexto = new LojaContext()) {
                contexto.Produtos.Add( prod );
                contexto.SaveChanges();
            }
        }
    }
}
