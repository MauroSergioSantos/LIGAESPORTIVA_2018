using System;
using System.Collections.Generic;
using System.Text;

namespace SGLE.ApplicationCore.__2._1___Entities
{
    public class Atleta
    {
        public Atleta()
        {

        }

        public int AtletaId { get; set; }
        public string NomedoAtleta { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public EquipeCategoria Categoria { get; set; }
        public PosicaoCampo Posicao { get; set; }
        public string Endereco { get; set; }
    }
}
