using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyAppStore.Site.Models.Client
{
    public class DisplayClientModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombres")]
        public string FirstName { get; set; }

        [DisplayName("Apellidos")]
        public string LastName { get; set; }

        [DisplayName("Cédula/RTN")]
        public string IdNumber { get; set; }
        
        [DisplayName("¿Activo?")]
        public bool IsActive { get; set; }
    }
}