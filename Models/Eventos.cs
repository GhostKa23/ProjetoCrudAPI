using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoCrudAPI.Properties.Model
{
    public class Eventos
    {
        public int EventoId { get; set; }
        public string NomeEvento { get; set; }
        public int OrganizadorId {get; set;}
        public DateTime DataEvento { get; set; }
        public DateTime HoraEvento {get; set;}
         public string NivelHabilidadeId { get; set; }
        public int ModalidadeId { get; set; }

    }
}