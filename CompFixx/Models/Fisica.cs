using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CompFixx.Models
{
    public class Fisica : Pessoa
    {
        public string cpf { get; set }
        public string idade { get; set; }
        public string rg { get; set; }
        public string nacionalidade { get; set; }
    }
}


