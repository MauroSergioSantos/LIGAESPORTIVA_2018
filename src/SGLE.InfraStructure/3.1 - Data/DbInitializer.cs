using SGLE.ApplicationCore.__2._1___Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGLE.InfraStructure._3._1___Data
{
    public static class DbInitializer
    {

        public static void Initialize(LigaEsportivaContext Context)
        {

            if (Context.Arbitros.Any())
            {

                return;
            }

            var arbitros = new Arbitro[]
            {
                new Arbitro
                {
                    NomeArbitro = "Antonio Manoel da Silva",
                    CPF = "79804244330",
                    RG = "035030",
                    Altura = 1.80M,
                    Peso = 79,
                    DataNascimento = new
                    DateTime(1974,05,04),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cuiabá",
                    Endereco = "Rua das Flores nr 20",
                    Tipo = TipoArbitro.Arbitro
                },

                new Arbitro
                {
                    NomeArbitro = "José Carlos Aguiar",
                    CPF = "81124926119",
                    RG = "047035",
                    Altura = 1.77M,
                    Peso = 76,
                    DataNascimento = new
                    DateTime(1971,17,12),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Poconé",
                    Endereco = "Rua das Dalias nr 35",
                    Tipo = TipoArbitro.Arbitro
                },

                new Arbitro
                {
                    NomeArbitro = "Pedro Paulo dos santos",
                    CPF = "63843314896",
                    RG = "09517215",
                    Altura = 1.82M,
                    Peso = 69,
                    DataNascimento = new
                    DateTime(1968,17,03),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cáceres",
                    Endereco = "Rua das Orquideas nr 40",
                    Tipo = TipoArbitro.ArbitroAssistente 
                }
            };

            Context.AddRange(arbitros);

            var assistentes = new Assistente[]
            {

                new Assistente
                {
                    NomeAssistente = "Franklin Martins",
                    CPF = "63843314896",
                    RG = "09517215",
                    Altura = 1.82M,
                    Peso = 69,
                    DataNascimento = new
                    DateTime(1968,17,03),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cáceres",
                    Endereco = "Rua das Orquideas nr 40",
                    Tipo = TipoAssistente.Assistente1,
                    Arbitro = arbitros[1]
                },

                new Assistente
                {
                    NomeAssistente = "Pablo Fayouk",
                    CPF = "62815714523",
                    RG = "403289440",
                    Altura = 1.72M,
                    Peso = 63,
                    DataNascimento = new
                    DateTime(1968,17,03),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cáceres",
                    Endereco = "Rua 45 Qda 32 nr 40",
                    Tipo = TipoAssistente.Assistente2,
                    Arbitro = arbitros[1]
                },

                new Assistente
                {
                    NomeAssistente = "Francisco Pereira de Carvalho",
                    CPF = "64041737516",
                    RG = "429434121",
                    Altura = 1.75M,
                    Peso = 68,
                    DataNascimento = new
                    DateTime(1969,27,08),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Rondonópolis",
                    Endereco = "Av José Torquato nr 142",
                    Tipo = TipoAssistente.Assistente2,
                    Arbitro = arbitros[1]
                }
            };

            Context.AddRange(assistentes);

            Context.SaveChanges();
        }
    }
}
