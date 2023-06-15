using System;
using System.Collections.Generic;

namespace Rc_service.Models
{
    public partial class Propietario
    {
        public Propietario()
        {
            Inmuebles = new HashSet<Inmueble>();
        }

        public string IdPropietario { get; set; } = null!;
        public string NamePropietario { get; set; } = null!;
        public string LastnamePropietario { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int UbicacionId { get; set; }

        public virtual Ubicacion Ubicacion { get; set; } = null!;
        public virtual ICollection<Inmueble> Inmuebles { get; set; }
    }
}
