using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class TourPhenotype : Phenotype
    {

        public int[] Tour { get; set; }


        public override string GetPhenotypeString()
        {
            string s = "";
            for (int i=0; i<Tour.Length; i++)
            {
                s += Tour[i].ToString() + ",";
            }
            return s;
        }
    }
}
