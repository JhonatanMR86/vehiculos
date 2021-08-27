﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehiculos.API.Data.Entities
{
    public class VehiclesType
    {
        public int id { get; set; }

        [Display(Name ="Tipo de Veichulo")]
        [MaxLength(50, ErrorMessage ="El campo {0} no puede tener mas de {1} carácteres.")]

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Description { get; set; }
    }
}
