using Cadastro.Controllers;
using Cadastro.Domain.Entities;
using Cadastro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Código Cliente")]
        [Required(ErrorMessage = "O cliente é requerido.")]
        public int IdClient { get; set; }

        [Display(Name = "Cliente")]
        public Client Client { get; set; }

        [Display(Name = "Código da Categoria")]
        [Required(ErrorMessage = "A categoria é requerido.")]
        public int IdCategory { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O produto é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O valor é requerido.")]
        public decimal Value { get; set; }

        [Display(Name = "Disponivel")]
        public bool Active { get; set; }


    }

}

