using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class SymbolPhenotype : Phenotype
    {
        public List<int> symbols;

        public SymbolPhenotype()
        {
            symbols = new List<int>();
        }

        public override string GetPhenotypeString()
        {
            return string.Join(",", symbols.ToArray());
        }
    }
}
