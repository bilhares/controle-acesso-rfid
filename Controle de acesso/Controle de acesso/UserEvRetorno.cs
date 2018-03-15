using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_acesso
{
    public class UserEvRetorno
    {
        public string nomeUser { get; set; }
        public string nomeEvento { get; set; }
        public string emailUser { get; set; }
        public byte[] ftUser { get; set; }
        public byte[] ftEvento { get; set; }
        public string local { get; set; }
        public DateTime data { get; set; }
        public double preco { get; set; }
          
    }
}
