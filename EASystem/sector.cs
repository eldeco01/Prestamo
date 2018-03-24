using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASystem
{
    public class sector
    {
        public int id { get; set; }
        public int idCiu { get; set; }
        public string nomSector { get; set; }

        public sector() { }

        public sector(int pId, int pIdCiu, string pNomSector)
        {
            this.id = pId;
            this.idCiu = pIdCiu;
            this.nomSector = pNomSector;
        }
    }
}
