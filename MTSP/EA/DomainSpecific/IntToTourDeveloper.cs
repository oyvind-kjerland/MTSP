using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class IntToTourDeveloper : PhenotypeDeveloper
    {
        public override Phenotype Develop(Genotype genotype)
        {
            IntGenotype intGenotype = (IntGenotype)genotype;
            TourPhenotype tourPhenotype = new TourPhenotype();

            int max = intGenotype.Max;
            int[] tour = new int[max];

            tourPhenotype.Tour = tour;

            // Fill in possible cities
            List<int> possibleCities = new List<int>(max);
            for (int i = 0; i < max; i++)
            {
                possibleCities.Add(i);
            }

            
            // Choose cities based on genotype
            int c;
            for (int i = 0; i < max; i++)
            {
                c = intGenotype.List[i] % possibleCities.Count;
                tour[i] = possibleCities[c];
                possibleCities.RemoveAt(c);
            }

            return tourPhenotype;
        }
    }
}
