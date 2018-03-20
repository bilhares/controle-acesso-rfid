using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_tag
{
    public class Evento
    {
        public long id { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
        public String local { get; set; }
        public double preco { get; set; }
        public bool ativo { get; set; }
        public byte[] foto { get; set; }
    }
}
