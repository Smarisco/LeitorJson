using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioJson.Model
{
    public class UnidadeOrcamentaria
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string UsuarioInclusaoRegistro { get; set; }
        public DateTime DataInclusaoRegistro { get; set; }
        public int UnidadeGestoraCodigo { get; set; }
        public virtual UnidadeGestora UnidadeGestora { get; set; }

       
    }
}
