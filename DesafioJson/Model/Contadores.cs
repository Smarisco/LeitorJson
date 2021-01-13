using System;

namespace DesafioJson.Model
{
    public class Contadores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public  DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }
       
        public virtual UnidadeGestora UnidadeGestora { get; set; }
    }
}
