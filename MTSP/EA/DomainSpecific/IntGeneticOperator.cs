using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class IntGeneticOperator : GeneticOperator
    {
        public override void Crossover(Genotype parent1Genotype, Genotype parent2Genotype, Genotype child1Genotype, Genotype child2Genotype)
        {
            float selectedValue = (float)random.NextDouble();

            if (selectedValue < CrossoverRate)
            {

                // Choose random crossover point
                IntGenotype intParent1 = (IntGenotype)parent1Genotype;
                IntGenotype intParent2 = (IntGenotype)parent2Genotype;
                IntGenotype intChild1 = (IntGenotype)child1Genotype;
                IntGenotype intChild2 = (IntGenotype)child2Genotype;

                int numInts = intParent1.Length;
                int crossoverPoint = random.Next(numInts);

                // Child 1 gets 
                for (int i = 0; i < numInts; i++)
                {
                    if (i < crossoverPoint)
                    {
                        intChild2.List[i] = intParent1.List[i];
                    }
                    else
                    {
                        intChild1.List[i] = intParent2.List[i];
                    }
                }
            }
            return;
        }

        public override void Mutate(Genotype genotype)
        {
            IntGenotype intGenotype = (IntGenotype)genotype;
            for (int i = 0; i < intGenotype.Length; i++)
            {
                float selectedValue = (float)random.NextDouble();
                if (selectedValue < MutationRate)
                {
                    intGenotype.List[i] ^= 1;
                }
            }
            return;
        }
    }
}
