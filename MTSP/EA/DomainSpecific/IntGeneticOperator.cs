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
                int max = intParent1.Max;
                //int crossoverPoint = random.Next(numInts);

                for (int i = 0; i < numInts; i++)
                {
                    intChild1.List[i] = -1;
                    intChild2.List[i] = -1;
                }

                
                for (int i=0; i<numInts/2; i++)
                {
                    int position = random.Next(max);
                    intChild1.List[position] = intParent1.List[position];
                    intChild2.List[position] = intParent2.List[position];
                }

                // Current position in parents
                int pos1 = 0;
                int pos2 = 0;

                // For each element in children check if a city is set or not
                // if not, get city from other parent and increment
                for (int i=0; i<numInts; i++)
                {

                    // Child 1
                    if (intChild1.List[i] == -1)
                    {
                        while (pos2 < numInts)
                        {
                            if (!intChild1.List.Contains(intParent2.List[pos2]))
                            {
                                intChild1.List[i] = intParent2.List[pos2];
                                break;
                            }
                            pos2++;
                        }
                    }

                    // Child 2
                    if (intChild2.List[i] == -1)
                    {
                        while (pos1 < numInts)
                        {
                            if (!intChild2.List.Contains(intParent1.List[pos1]))
                            {
                                intChild2.List[i] = intParent1.List[pos1];
                                break;
                            }
                            pos1++;
                        }
                    }
                }


                /*
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
            */

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
                    // Swap with another index
                    int temp = intGenotype.List[i];
                    int j = random.Next(48);
                    intGenotype.List[i] = intGenotype.List[j];
                    intGenotype.List[j] = temp;
                    //intGenotype.List[i] ^= 1;
                }
            }
            return;
        }
    }
}
