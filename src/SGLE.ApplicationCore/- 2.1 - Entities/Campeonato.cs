using System;
using System.Collections.Generic;
using System.Text;

namespace SGLE.ApplicationCore.__2._1___Entities
{
    public class Campeonato
    {
        public Campeonato()
        {

        }

        public int CampeonatoId { get; set; }
        public string NomedoCampeonato { get; set; }
        public int Temporada { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public List<Equipe> Equipes { get; set; }
    }
}
