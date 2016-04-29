using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class TournamentSelector : ParentSelector
    {
        public int TournamentSize;

        public override void Select(List<Individual> parentList, List<Individual> adultPopulation)
        {
            // Clear the list of parents
            parentList.Clear();
            Individual best;
            Individual p;

            for (int n=0; n<ChildCount; n++)
            {
                best = null;
                for (int i=0; i<TournamentSize; i++)
                {
                    p = adultPopulation[random.Next(adultPopulation.Count)];
                    
                    if (best == null || p.Rank > best.Rank)
                    {
                        best = p;
                    } else if (p.Rank == best.Rank)
                    {
                        if (p.CrowdingDistance > best.CrowdingDistance)
                        {
                            best = p;
                        }
                    }
                }
                parentList.Add(best);
            }
        }
    }
}
