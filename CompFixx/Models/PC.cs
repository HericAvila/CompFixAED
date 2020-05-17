using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompFixx.Models
{
    class PC: Maquina   
    {
        public int fonte { get; set; }
        public bool leitorOptico { get; set; }
        public string placaM { get; set; }
    }
}
