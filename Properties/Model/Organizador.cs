using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoCrudAPI.Properties.Model
{
    public class Organizador
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;

        public string Telefone { get; set; } = "";

        public string Email { get; set; }
         public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }
        [NotMapped]
        public string PasswordString { get; set; } = string.Empty;


    }
}