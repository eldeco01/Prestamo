using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASystem
{
    public class ciudad
    {
        public int id { get; set; }
        public string nomCiu { get; set; }

        public ciudad() { }

        public ciudad(int pId, string pNomCiu)
        {
            this.id = pId;
            this.nomCiu = pNomCiu;
        }

        
    }
}
