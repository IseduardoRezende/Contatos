using System;
using System.Collections.Generic;
using System.Text;

namespace Contatos1._1.Model
{
    public class Contato
    {
        public int Id_Contato { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Descricao { get; set; }
        public bool Status_Usuario { get; set; }
    }
}
