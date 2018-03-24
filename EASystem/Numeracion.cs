using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASystem
{
    public class Numeracion 
    {
        public Boolean modSiNo{ get; set; }
        public string nomCampo { get; set; }
        public int valEnum { get; set; }
        

        
        public Numeracion() {}

        public Numeracion(Boolean pMod, string pCampo, int pVal)
        {
            this.modSiNo = pMod;
            this.nomCampo = pCampo;
            this.valEnum = pVal;
        }
    }
}
