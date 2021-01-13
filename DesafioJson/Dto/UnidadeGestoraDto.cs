using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioJson.Dto
{
    public class UnidadeGestoraDto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Nome_reduzido { get; set; }
        public string Data_Criacao { get; set; }
        public string Cnpj { get; set; }
        public string Integracao_compras { get; set; }
        public bool Emite_pre_empenho_integrado { get; set; }
        public virtual UnidadeOrcamentariaDto UnidadeOrcamentaria { get; set; }
        public virtual List<ContadoresDto> Contadores { get; set; } = new List<ContadoresDto>();
    }
}
