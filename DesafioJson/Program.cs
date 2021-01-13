using System;
using System.Collections.Generic;
using System.IO;
using DesafioJson.Model;
using Newtonsoft.Json;
using DesafioJson.Data;
using DesafioJson.Dto;

namespace DesafioJson
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquivos();
        }

        private static void LerArquivos()
        {
            //Caminho para leitura do arquivo Json
            string jsonFilePath = @"C:\Projetos\";
            DirectoryInfo directoryInfo = new DirectoryInfo(jsonFilePath);

            foreach (var file in directoryInfo.GetFiles("*.json"))
            {
                using (StreamReader r = new StreamReader(file.FullName))
                {
                    Console.WriteLine("INICIANDO INSERÇÃO");
                    Console.WriteLine();
                    Console.WriteLine("Lendo arquivo: " + file.Name);
                    Console.WriteLine();
                    string json = r.ReadToEnd();
                    var unidadeGestoraDto = JsonConvert.DeserializeObject<UnidadeGestoraDto>(json);
                    Console.WriteLine("Lendo Unidade Gestora: " + unidadeGestoraDto.Codigo);

                    var unidadeGestora = new UnidadeGestora();

                    unidadeGestora = ConvertParaUnidadeGestora(unidadeGestoraDto);
                    unidadeGestora.UnidadeOrcamentaria = new UnidadeOrcamentaria();
                    unidadeGestora.UnidadeOrcamentaria = ConvertParaUnidadeOrcamentaria(unidadeGestoraDto.UnidadeOrcamentaria);
                    unidadeGestora.Contadores = ConvertParaContadores(unidadeGestoraDto.Contadores);
             
                    InserirDados(unidadeGestora);
                }
            }
        }

        //Método para conversão
        private static UnidadeOrcamentaria ConvertParaUnidadeOrcamentaria(UnidadeOrcamentariaDto dto)
        {
            var unidadeOrcamentaria = new UnidadeOrcamentaria();

            unidadeOrcamentaria.Codigo = dto.Codigo;
            unidadeOrcamentaria.Nome = dto.Nome;
            unidadeOrcamentaria.UsuarioInclusaoRegistro = dto.Usuario_inclusao_registro;
            unidadeOrcamentaria.DataInclusaoRegistro = dto.Data_inclusao_registro;

            return unidadeOrcamentaria;
        }
        //Método para conversão
        private static UnidadeGestora ConvertParaUnidadeGestora (UnidadeGestoraDto dto)
        {
            var unidadeGestora = new UnidadeGestora();

            unidadeGestora.Codigo = dto.Codigo;
            unidadeGestora.Nome = dto.Nome;
            unidadeGestora.NomeReduzido = dto.Nome_reduzido;
            unidadeGestora.DataCriacao = Convert.ToDateTime(dto.Data_Criacao);
            unidadeGestora.Cnpj = dto.Cnpj.Replace(".", "").Replace("/", "").Replace("-", "");
            unidadeGestora.IntegracaoCompras = dto.Integracao_compras == "S" ? true:false;
            unidadeGestora.EmitePreEmpenhoIntegrado = dto.Emite_pre_empenho_integrado;

            return unidadeGestora;

        }
        //Método para conversão da lista
        private static List<Contadores> ConvertParaContadores (List<ContadoresDto> dto)
        {
            var contadores = new List<Contadores>();

            foreach (var item in dto)
            {
                var contador = new Contadores();
                {

                    contador.Nome = item.Nome;
                    contador.DataNascimento = Convert.ToDateTime(item.Data_nascimento);
                    contador.Endereco = item.Endereco;
                    contador.Numero = item.Numero;
                    contador.Bairro = item.Bairro;
                    contador.Ativo = item.Ativo;
                };
                
                contadores.Add(contador);
            }

            return contadores;
            
        }

        private static void InserirDados(UnidadeGestora unidadeGestora)
        {
            using var db = new UnidadeGestoraContext();
            

            

            db.UnidadeGestora.Add(unidadeGestora);

            var registros = db.SaveChanges();

            Console.WriteLine($"Total Registros: {registros}");
        }

        
    }
}
