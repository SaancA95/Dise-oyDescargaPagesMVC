using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiseñoPaginas.Models
{
    public class Cliente
    {
        public string ClienteID { get; set; }

        public string NombreCompleto { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

    }
}