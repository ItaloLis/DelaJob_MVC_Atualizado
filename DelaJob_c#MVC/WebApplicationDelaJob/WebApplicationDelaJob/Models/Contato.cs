using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDelaJob.Models
{
    public class Contato
    {
        public String email { get; set; }
        public String nome { get; set; }
        public String assunto { get; set; }
        public String telefone { get; set; }
        public String mensagem { get; set; }
    }
}
