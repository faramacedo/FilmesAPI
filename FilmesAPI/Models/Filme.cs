﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; internal set; }
        [Required(ErrorMessage ="Campo Título é obrigatório.")]
        public string Titulo{ get; set; }
        [Required(ErrorMessage = "Campo diretor é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(40,ErrorMessage ="O campo Genero deve ter até 40 caracteres.")]
        public string  Genero { get; set; }
        [Range(1,600, ErrorMessage ="A duração deve ser estar 1min e 10h.")]
        public int Duracao { get; set; }
    }
}
