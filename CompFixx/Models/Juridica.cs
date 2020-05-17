using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CompFixx.Models
{
    public class Juridica : Pessoa 
    {
        public string razaoSocial { get; set; }
        public string cnae { get; set; }
        public bool nacionalidade { get; set; }
        public string tipoEmpresa { get; set; }
        public string responsavel { get; set; }

    }
}
