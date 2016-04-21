using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class TourEvaluator : FitnessEvaluator
    {
        public CityData cityData;
        
        public override double Evaluate(Individual individual)
        {
            TourPhenotype phenotype = (TourPhenotype)individual.Phenotype;

            // Fitness 1 is cost
            int totalCost = 0;

            // Fitness 2 is distance
            int totalDistance = 0;
            int[] tour = phenotype.Tour;

            // Want to minimize both
            for (int i=0; i<tour.Length-1; i++)
            {
                totalCost += cityData.CostArr[tour[i], tour[i + 1]];
                totalDistance += cityData.DistanceArr[tour[i], tour[i + 1]];
            }
            // Add the last edge
            totalCost += cityData.CostArr[tour.Last(), tour[0]];
            totalDistance += cityData.DistanceArr[tour.Last(), tour[0]];

            individual.Cost = totalCost;
            individual.Distance = totalDistance;

            return 0;
        }
    }
}
