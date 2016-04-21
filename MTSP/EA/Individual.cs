using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP
{
    class Individual : IComparable
    {
        // The individual's genotype
        public Genotype Genotype { get; set; }

        // The individual's phenotype
        public Phenotype Phenotype { get; set; }

        // The individual's fitness
        public double Cost { get; set; }
        public double Distance { get; set; }

        // The individual's scaled fitness
        public int Rank { get; set; }
        public double CrowdingDistance { get; set; } 

        // Comparison
        public int CompareTo(object obj)
        {
            Individual other = obj as Individual;

            return 0;
        }
    }
}
