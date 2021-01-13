using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioJson.Dto
{
    public class ContadoresDto
    {
        public string Nome { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }

        public virtual UnidadeGestoraDto UnidadeGestora { get; set; }
    }
}
