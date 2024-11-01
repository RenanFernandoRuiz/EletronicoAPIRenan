﻿using System.ComponentModel.DataAnnotations;

namespace EletronicoAPI.Models
{
    public class Fornecedor
    {
        [Key]

        public Guid Id { get; set; } = Guid.NewGuid();
        public string NomeEmpresa { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
