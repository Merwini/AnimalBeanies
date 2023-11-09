using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Nuff.AnimalHats
{
    public class ThoughtWorker_AnimalHat : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            List<Apparel> wornApparel = p.apparel.WornApparel;
            for (int i = 0; i < wornApparel.Count; i++)
            {
                if (wornApparel[i].def.thingCategories.Contains(AH_CategoryDefOf.Nuff_AnimalHat))
                {
                    return true;
                }
            }

            return ThoughtState.Inactive;
        }
    }
}
