﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class ClassResta:ClassOperacion
    {
        public override void Operaciones()
        {
            Resultados = Valor1 - Valor2;
        }
    }
}
