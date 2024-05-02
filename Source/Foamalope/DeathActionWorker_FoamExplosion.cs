using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using Verse.AI.Group;

namespace Foamalope
{
    public class DeathActionWorker_FoamExplosion : DeathActionWorker
    {
        public override RulePackDef DeathRules => RulePackDefOf.Transition_DiedExplosive;

        public override void PawnDied(Corpse corpse, Lord prevLord)
        {
            GenExplosion.DoExplosion(radius: (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 0) ? 1.9f : ((corpse.InnerPawn.ageTracker.CurLifeStageIndex != 1) ? 4.9f : 2.9f), center: corpse.Position, map: corpse.Map, damType: DamageDefOf.Extinguish, instigator: corpse.InnerPawn, damAmount: -1, armorPenetration: -1f, explosionSound: null, weapon: null, projectile: null, intendedTarget: null, postExplosionSpawnThingDef: ThingDefOf.Filth_FireFoam, postExplosionSpawnChance: 1f, postExplosionSpawnThingCount: (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 0) ? 1 : ((corpse.InnerPawn.ageTracker.CurLifeStageIndex != 1) ? 3 : 2));
        }
    }
}
