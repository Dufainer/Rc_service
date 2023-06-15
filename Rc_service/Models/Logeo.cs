using System;
using System.Collections.Generic;

namespace Rc_service.Models
{
    public partial class Logeo
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
    }
}
