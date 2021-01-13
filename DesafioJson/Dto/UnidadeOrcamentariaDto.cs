using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioJson.Dto
{
    public class UnidadeOrcamentariaDto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Usuario_inclusao_registro { get; set; }
        public DateTime Data_inclusao_registro { get; set; }
        public int CodigoUnidadeGestora { get; set; }
        public virtual UnidadeGestoraDto UnidadeGestora { get; set; }
    }
}
