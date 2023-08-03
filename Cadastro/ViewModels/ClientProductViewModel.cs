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
    public class ClientProductViewModel
    {
        [Key]
        [Display(Name = "Produto")]
        public IEnumerable<ProductViewModel> Product { get; set; }

        
        [Display(Name = "Cliente")]
        public IEnumerable<ClientViewModel> Client { get; set; }

    }

    

}

