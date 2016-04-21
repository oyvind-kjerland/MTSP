using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MTSP.EA
{
    class EALoop
    {
        public List<Individual> ChildPopulation { get; set; }
        public List<Individual> AdultPopulation { get; set; }
        protected List<Individual> ParentList { get; set; }

        public PhenotypeDeveloper PhenotypeDeveloper { get; set; }
        public FitnessEvaluator FitnessEvaluator { get; set; }
        public AdultSelector AdultSelector { get; set; }
        public ParentSelector ParentSelector { get; set; }
        public GeneticOperator GeneticOperator { get; set; }
        public Genotype Genotype { get; set; }

        public int generation;
        public int ChildCount { get; set; }
        public bool Elitism { get; set; }

        public bool Active { get; set; }

        public void Initialize()
        {
            generation = 0;

            ChildPopulation = new List<Individual>();
            Random random = new Random();

            for (int i=0; i<ChildCount; i++)
            {
                Individual individual = new Individual();
                individual.Genotype = Genotype.Clone();
                individual.Genotype.Randomize(random);
                ChildPopulation.Add(individual);
            }

            AdultPopulation = new List<Individual>();
            ParentList = new List<Individual>();

        }

        public void Iterate()
        {

            // Get the phenotypes for the individuals
            foreach (Individual individual in ChildPopulation)
            {
                individual.Phenotype = PhenotypeDeveloper.Develop(individual.Genotype);
            }


            foreach (Individual individual in ChildPopulation)
            {
                FitnessEvaluator.Evaluate(individual);
            }

            // Perform adult selection
            AdultSelector.Select(ChildPopulation, AdultPopulation);

            // Perform parent selection
            ParentSelector.Select(ParentList, AdultPopulation);

            // Make children
            Individual parent1, parent2, child1, child2;

            // Special case if child population size is 1
            if (ChildCount == 1)
            {
                child1 = new Individual();
                child1.Genotype = ParentList[0].Genotype.Clone();
                GeneticOperator.Mutate(child1.Genotype);
                ChildPopulation.Add(child1);
            } else
            {
                for (int i=0; i<ParentList.Count-1; i+=2)
                {
                    parent1 = ParentList[i];
                    parent2 = ParentList[i + 1];

                    child1 = new Individual();
                    child2 = new Individual();

                    child1.Genotype = parent1.Genotype.Clone();
                    child2.Genotype = parent2.Genotype.Clone();

                    // Crossover
                    GeneticOperator.Crossover(parent1.Genotype, parent2.Genotype, child1.Genotype, child2.Genotype);

                    // Mutate
                    GeneticOperator.Mutate(child1.Genotype);
                    GeneticOperator.Mutate(child2.Genotype);

                    ChildPopulation.Add(child1);
                    ChildPopulation.Add(child2);
                }

                // check if the count is divisible by 2
                if (ParentList.Count % 2 == 1)
                {
                    child1 = new Individual();
                    child1.Genotype = ParentList[0].Genotype.Clone();
                    GeneticOperator.Mutate(child1.Genotype);
                    ChildPopulation.Add(child1);
                }
            }


            // Update generation
            generation++;

        }
    }
}
