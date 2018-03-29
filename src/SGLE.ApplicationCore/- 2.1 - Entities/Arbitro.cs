using System;
using System.Collections.Generic;
using System.Text;

namespace SGLE.ApplicationCore.__2._1___Entities
{
    public class Arbitro
    {
        public Arbitro()
        {

        }

        public int ArbitroId { get; set; }
        public string NomeArbitro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public TipoArbitro Tipo { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Endereco { get; set; }
    }
}
