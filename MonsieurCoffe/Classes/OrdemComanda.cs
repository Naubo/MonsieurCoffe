using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsieurCoffe.Classes
{
    public class OrdemComanda
    {
    public int Id { get; set; }
        public int Id_Ficha { get; set; }
        public int Id_Produto { get; set; }
        public int quantidade { get; set; }
        public int Id_Resp { get; set; }
        public DateTime Data_adic { get; set; }
        public int Situacao { get; set; }


    }
}
