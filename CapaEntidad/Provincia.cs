﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Provincia
    {
        public string IdProvincia { get; set; }
        public string descripcion { get; set; }
        public Departamento oDepartamento { get; set; }
    }
}
