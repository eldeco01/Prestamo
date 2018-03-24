using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASystem
{
    public class Tipos
    {
        public int id { get; set; }
        public string nom { get; set; }

        public Tipos() { }

        public Tipos(int pId, string pNom)
        {
            this.id = pId;
            this.nom = pNom;
        }
    }
}
