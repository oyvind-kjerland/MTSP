using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP
{
    [Serializable]
    public class Population
    {
        public List<double> cost;
        public List<double> distance;
        public List<int> rank;


        public Population(List<Individual> population)
        {
            cost = new List<double>();
            distance = new List<double>();
            rank = new List<int>();

            foreach (Individual i in population)
            {
                cost.Add(i.Cost);
                distance.Add(i.Distance);
                rank.Add(i.Rank);
            }

        }

        public List<Individual> RestorePopulation()
        {
            List<Individual> population = new List<Individual>();
            for (int i = 0; i < cost.Count; i++)
            {
                Individual ind = new Individual();
                ind.Cost = cost[i];
                ind.Distance = distance[i];
                ind.Rank = rank[i];
                population.Add(ind);
            }

            return population;
        }
    }
}
