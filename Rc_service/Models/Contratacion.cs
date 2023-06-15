using System;
using System.Collections.Generic;

namespace Rc_service.Models
{
    public partial class Contratacion
    {
        public int Id { get; set; }
        public int OfertasIdOfertas { get; set; }
        public int EstadosId { get; set; }

        public virtual Estado Estados { get; set; } = null!;
        public virtual Oferta OfertasIdOfertasNavigation { get; set; } = null!;
    }
}
