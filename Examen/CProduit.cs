using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class CProduit
    {
        public int Idprod { get; set; }
        public string Libelleprod { get; set; }
        public int Prix { get; set; }
        public int Qte { get; set; }



        public override string ToString()
        {
            return $"{Libelleprod},{Prix},{Qte}";
        }
    }
}
