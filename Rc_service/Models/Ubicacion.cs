using System;
using System.Collections.Generic;

namespace Rc_service.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            Inmuebles = new HashSet<Inmueble>();
            PrestadoresDeServicios = new HashSet<PrestadoresDeServicio>();
            Propietarios = new HashSet<Propietario>();
        }

        public int Id { get; set; }
        public string Pais { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Municipio { get; set; } = null!;
        public string Barrio { get; set; } = null!;
        public string Direccion { get; set; } = null!;

        public virtual ICollection<Inmueble> Inmuebles { get; set; }
        public virtual ICollection<PrestadoresDeServicio> PrestadoresDeServicios { get; set; }
        public virtual ICollection<Propietario> Propietarios { get; set; }
    }
}
