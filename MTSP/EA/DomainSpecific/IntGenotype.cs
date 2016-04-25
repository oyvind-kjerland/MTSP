using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP.EA.DomainSpecific
{
    class IntGenotype : Genotype
    {
        public int[] List { get; set; }
        public int Length { get; private set; }
        public int Min;
        public int Max;

        public IntGenotype(int length)
        {
            Length = length;
            List = new int[length];
        }

        public IntGenotype(int length, int[] list, int min, int max)
        {
            Length = length;
            List = list;
            Min = min;
            Max = max;
        }

        public override Genotype Clone()
        {
            return new IntGenotype(Length, (int[])List.Clone(), Min, Max);
        }

        public override void Randomize(Random random)
        {
            for (int i=0; i<Length; i++)
            {
                List[i] = random.Next(Min, Max);
            }
        }
    }
}
