﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class MixingSelector : AdultSelector
    {

        public override void Select(List<Individual> childPopulation, List<Individual> adultPopulation)
        {
            // Add all childs into the adult population
            adultPopulation.AddRange(childPopulation);

            // Clear child population
            childPopulation.Clear();

            // Sort the adult list based on fitness
            adultPopulation.Sort();

            // Filter out the worst individuals
            adultPopulation.RemoveRange(AdultCount, adultPopulation.Count - AdultCount);

        }
    }
}
