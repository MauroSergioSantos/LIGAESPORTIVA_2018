using System;
using System.Collections.Generic;
using System.Text;

namespace SGLE.ApplicationCore.__2._1___Entities
{
    public class Assistente
    {
        public Assistente()
        {

        }

        public int AssistenteId { get; set; }
        public string NomeAssistente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public TipoAssistente Tipo { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Endereco { get; set; }
        public int ArbitroId { get; set; }
        public Arbitro Arbitro { get; set; }
    }
}
