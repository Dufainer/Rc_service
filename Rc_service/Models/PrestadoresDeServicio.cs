using System;
using System.Collections.Generic;

namespace Rc_service.Models
{
    public partial class PrestadoresDeServicio
    {
        public string IdPrestador { get; set; } = null!;
        public string NamePrestador { get; set; } = null!;
        public string LastnamePrestador { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int UbicacionId { get; set; }
        public int ServiciosIdServicio { get; set; }

        public virtual Servicio ServiciosIdServicioNavigation { get; set; } = null!;
        public virtual Ubicacion Ubicacion { get; set; } = null!;
    }
}
