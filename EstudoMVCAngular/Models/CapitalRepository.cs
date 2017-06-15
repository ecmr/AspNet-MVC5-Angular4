using System.Collections.Generic;

namespace EstudoMVCAngular.Models
{
    public static class CapitalRepository
    {
        private static List<Capital> _capitais;

        static CapitalRepository()
        {
            _capitais = new List<Capital>();

            _capitais.Add(new Capital()
            {
                Estado = "Acre",
                NomeCidade = "Rio Branco",
                Regiao = "Norte"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Alagoas",
                NomeCidade = "Maceió",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Amapá",
                NomeCidade = "Macapá",
                Regiao = "Norte"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Amazonas",
                NomeCidade = "Manaus",
                Regiao = "Norte"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Bahia",
                NomeCidade = "Salvador",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Ceará",
                NomeCidade = "Fortaleza",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Distrito Federal",
                NomeCidade = "Brasília",
                Regiao = "Centro-Oeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Espírito Santo",
                NomeCidade = "Vitória",
                Regiao = "Sudeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Goiás",
                NomeCidade = "Goiânia",
                Regiao = "Centro-Oeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Maranhão",
                NomeCidade = "São Luís",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Mato Grosso",
                NomeCidade = "Cuiabá",
                Regiao = "Centro-Oeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Mato Grosso do Sul",
                NomeCidade = "Campo Grande",
                Regiao = "Centro-Oeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Minas Gerais",
                NomeCidade = "Belo Horizonte",
                Regiao = "Sudeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Pará",
                NomeCidade = "Belém",
                Regiao = "Norte"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Paraíba",
                NomeCidade = "João Pessoa",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Paraná",
                NomeCidade = "Curitiba",
                Regiao = "Sul"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Pernambuco",
                NomeCidade = "Recife",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Piauí",
                NomeCidade = "Teresina",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Rio de Janeiro",
                NomeCidade = "Rio de Janeiro",
                Regiao = "Sudeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Rio Grande do Norte",
                NomeCidade = "Natal",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Rio Grande do Sul",
                NomeCidade = "Porto Alegre",
                Regiao = "Sul"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Rondônia",
                NomeCidade = "Porto Velho",
                Regiao = "Norte"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Roraima",
                NomeCidade = "Boa Vista",
                Regiao = "Norte"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Santa Catarina",
                NomeCidade = "Florianópolis",
                Regiao = "Sul"
            });
            _capitais.Add(new Capital()
            {
                Estado = "São Paulo",
                NomeCidade = "São Paulo",
                Regiao = "Sudeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Sergipe",
                NomeCidade = "Aracaju",
                Regiao = "Nordeste"
            });
            _capitais.Add(new Capital()
            {
                Estado = "Tocantins",
                NomeCidade = "Palmas",
                Regiao = "Norte"
            });
        }

        public static List<Capital> ListarCapitais()
        {
            return _capitais;
        }
    }

}
