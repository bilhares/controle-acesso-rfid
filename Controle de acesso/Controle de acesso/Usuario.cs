using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_acesso
{
    public class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public byte[] foto { get; set; }
        public bool ativo { get; set; }
    }
}
