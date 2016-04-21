using MTSP.EA.DomainSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA
{
    class FitnessProportionate : GlobalParentSelector
    {

        public override void Scale(List<Individual> adultPopulation)
        {

            foreach (Individual individual in adultPopulation)
            {
                individual.ScaledFitness = individual.Fitness;
            }

            // Normalize
            NormalizeScaledFitness(adultPopulation);
            
        }
    }
}
