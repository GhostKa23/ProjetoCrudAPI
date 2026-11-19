using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrudAPI.Properties.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }
        public string Cep { get; set; } = string.Empty;
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int EventoId { get; set; }
    }
}