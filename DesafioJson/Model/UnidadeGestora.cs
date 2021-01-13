using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioJson.Model
{
    public class UnidadeGestora
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string NomeReduzido { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Cnpj { get; set; }
        public bool IntegracaoCompras { get; set; }
        public bool EmitePreEmpenhoIntegrado { get; set; }
        public virtual UnidadeOrcamentaria UnidadeOrcamentaria { get; set; }
        public virtual List<Contadores> Contadores { get; set; } = new List<Contadores>();
    }

}