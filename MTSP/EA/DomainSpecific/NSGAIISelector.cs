using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class NSGAIISelector : AdultSelector
    {
        public override void Select(List<Individual> childPopulation, List<Individual> adultPopulation)
        {

            // Combine populations
            List<Individual> combinedPopulation = new List<Individual>();
            combinedPopulation.AddRange(childPopulation);
            combinedPopulation.AddRange(adultPopulation);

            childPopulation.Clear();
            adultPopulation.Clear();

            // Obtain fronts of the combined population
            List<List<Individual>> fronts = FastNonDominatedSort(combinedPopulation);

            int currentRank = 0;
            List<Individual> currentFront = fronts[currentRank];

            while (adultPopulation.Count + currentFront.Count < AdultCount)
            {
                CrowdingDistanceAssignment(currentFront);
                adultPopulation.AddRange(currentFront);
                currentRank++;
                currentFront = fronts[currentRank];
            }

            CrowdingDistanceAssignment(currentFront);
            
            // Check special case
            if (adultPopulation.Count + currentFront.Count == AdultCount)
            {
                adultPopulation.AddRange(currentFront);
            } else
            {
                // Sort based on crowding distance
                currentFront.Sort((x, y) => x.CrowdingDistance.CompareTo(y.CrowdingDistance));

                // Take the first N=adultPopSize-AdultCount elements
                adultPopulation.AddRange(currentFront.GetRange(0, AdultCount - adultPopulation.Count - 1));
            }

        }

        private List<List<Individual>> FastNonDominatedSort(List<Individual> population)
        {

            // Initialize fronts
            List<List<Individual>> fronts = new List<List<Individual>>();
            List<Individual> currentFront = new List<Individual>();
            List<Individual> nextFront;

            // Add the first front
            fronts.Add(new List<Individual>());

            foreach (Individual i1 in population)
            {
                i1.DominatedSet = new HashSet<Individual>();

                foreach (Individual i2 in population)
                {
                    if (Dominates(i1, i2))
                    {
                        i1.DominatedSet.Add(i2);
                    } else if (Dominates(i2, i1))
                    {
                        i1.NumDominatedBy++;
                    }
                }
                if (i1.NumDominatedBy == 0)
                {
                    i1.Rank = 0;
                    // Add to first front
                    currentFront.Add(i1);
                }

            }

            int currentRank = 0;

            while (currentFront.Count > 0)
            {
                fronts.Add(currentFront);
                nextFront = new List<Individual>();
                foreach (Individual i1 in currentFront)
                {
                    foreach (Individual i2 in i1.DominatedSet)
                    {
                        i2.NumDominatedBy--;
                        if (i2.NumDominatedBy == 0)
                        {
                            i2.Rank = currentRank + 1;
                            nextFront.Add(i2);
                        }
                    }
                }
                currentRank += 1;
                currentFront = nextFront;
                
            }

            return fronts;
        }


        private bool Dominates(Individual i1, Individual i2)
        {
            return (i1.Cost < i2.Cost && i1.Distance < i2.Distance);
        }


        private void CrowdingDistanceAssignment(List<Individual> front)
        {
            int l = front.Count;

            if (l < 2) return;

            double mMin, mMax, mPrev, mNext;

            foreach (Individual i1 in front)
            {
                i1.CrowdingDistance = 0;
            }

            for (int m=0; m<2; m++)
            {
                if (m==0)
                {
                    // Sort on cost
                    front.Sort((x, y) => x.Cost.CompareTo(y.Cost));
                } else
                {
                    // Sort on distance
                    front.Sort((x, y) => x.Distance.CompareTo(y.Distance));
                }

                // Init extremas
                front[0].CrowdingDistance = double.PositiveInfinity;
                front[l - 1].CrowdingDistance = double.PositiveInfinity;

                for (int i=1; i<l-1; i++)
                {
                    if (m == 0)
                    {
                        mMin = front[0].Cost;
                        mMax = front[l - 1].Cost;
                        mPrev = front[i - 1].Cost;
                        mNext = front[i + 1].Cost;
                    } else
                    {
                        mMin = front[0].Distance;
                        mMax = front[l - 1].Distance;
                        mPrev = front[i - 1].Distance;
                        mNext = front[i + 1].Distance;
                    }
                    front[i].CrowdingDistance += (mNext - mPrev) / (mMax - mMin); 
                }
            }
        }
    }
}
