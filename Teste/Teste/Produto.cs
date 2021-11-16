using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste {
    public class Produto {

        public int Id { get; protected set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return $"Produto {this.Id}, {this.Nome}, {this.Categoria}, {this.Preco}";
        }
    }
}
