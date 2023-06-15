using System;
using System.Collections.Generic;

namespace Rc_service.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Oferta = new HashSet<Oferta>();
            PrestadoresDeServicios = new HashSet<PrestadoresDeServicio>();
        }

        public int IdServicio { get; set; }
        public string TipoServicio { get; set; } = null!;
        public string DetallesServicio { get; set; } = null!;

        public virtual ICollection<Oferta> Oferta { get; set; }
        public virtual ICollection<PrestadoresDeServicio> PrestadoresDeServicios { get; set; }
    }
}
