using System.Collections.Generic;
using System.Web.Mvc;
using DiseñoPaginas.Models;
using Rotativa;

namespace DiseñoPaginas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Define la URL de la Cabecera 
            string _headerUrl = Url.Action("HeaderPDF", "Home", null, Request.Url.Scheme);
            // Define la URL del Pie de página
            string _footerUrl = Url.Action("FooterPDF", "Home", null, Request.Url.Scheme);

            // Datos quemados
            var clientes = new List<Cliente>
            {
                new Cliente { ClienteID = "1", NombreCompleto = "Juan Pérez", Direccion = "Calle Falsa 123", Ciudad = "Ciudad X", Pais = "País Y", Telefono = "123456789", CorreoElectronico = "juan.perez@example.com" },
                new Cliente { ClienteID = "2", NombreCompleto = "Ana Gómez", Direccion = "Avenida Siempreviva 742", Ciudad = "Ciudad A", Pais = "País B", Telefono = "987654321", CorreoElectronico = "ana.gomez@example.com" }
            };

            return new ViewAsPdf("Index", clientes)
            {
                CustomSwitches = "--header-html " + _headerUrl + " --header-spacing 0 " +
                                 "--footer-html " + _footerUrl + " --footer-spacing 0",
                PageSize = Rotativa.Options.Size.A4,
                PageMargins = new Rotativa.Options.Margins(40, 10, 10, 10)
            };
        }

        public ActionResult HeaderPDF()
        {
            return View("HeaderPDF");
        }

        public ActionResult FooterPDF()
        {
            return View("FooterPDF");
        }
    }
}
