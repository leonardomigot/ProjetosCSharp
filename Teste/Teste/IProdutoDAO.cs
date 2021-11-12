using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal interface IProdutoDAO
    {
        void Create(Produto p);
        void Update(Produto p);
        void Delete(Produto p);
        IList<Produto> GetAll();


        
    }
}
