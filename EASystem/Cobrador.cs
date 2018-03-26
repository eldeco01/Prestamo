using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASystem
{
    class Cobrador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string dir { get; set; }
        public string tel { get; set; }
        public float comision { get; set; }

        public Cobrador() { }

        public Cobrador(int pId, string pNombre, string pDir, string pTel, float pComi)
        {
            this.id = pId;
            this.nombre = pNombre;
            this.dir = pDir;
            this.tel = pTel;
            this.comision = pComi;
        }
    }
}
