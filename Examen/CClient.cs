using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class CClient
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string nom { get; set; }
        public string tel { get; set; }
        public string adresse { get; set; }



        public override string ToString()
        {
            return $"{Prenom},{nom},{tel},{adresse}";
        }
    }
}
