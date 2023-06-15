using System;
using System.Collections.Generic;

namespace Rc_service.Models
{
    public partial class Inmueble
    {
        public Inmueble()
        {
            Oferta = new HashSet<Oferta>();
        }

        public int IdInmueble { get; set; }
        public string TipoInmueble { get; set; } = null!;
        public string DetallesInmueble { get; set; } = null!;
        public int UbicacionId { get; set; }
        public string PropietariosIdPropietario { get; set; } = null!;

        public virtual Propietario PropietariosIdPropietarioNavigation { get; set; } = null!;
        public virtual Ubicacion Ubicacion { get; set; } = null!;
        public virtual ICollection<Oferta> Oferta { get; set; }
    }
}
