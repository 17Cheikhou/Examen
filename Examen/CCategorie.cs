﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class CCategorie
    {
        public int Id { get; set; }
        public string Libelle { get; set; }


        public override string ToString()
        {
            return Libelle;
        }
    }
}
