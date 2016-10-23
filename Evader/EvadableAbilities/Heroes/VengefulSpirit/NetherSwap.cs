﻿namespace Evader.EvadableAbilities.Heroes.VengefulSpirit
{
    using Base;

    using Ensage;

    using static Data.AbilityNames;

    internal class NetherSwap : LinearTarget
    {
        #region Constructors and Destructors

        public NetherSwap(Ability ability)
            : base(ability)
        {
            CounterAbilities.Add(Lotus);
            CounterAbilities.Add(PhaseShift);
            CounterAbilities.Add(BallLightning);
            CounterAbilities.Add(Eul);
            CounterAbilities.Add(Manta);
            CounterAbilities.AddRange(VsDisable);
            CounterAbilities.Add(SleightOfFist);
            CounterAbilities.Add(TricksOfTheTrade);
            CounterAbilities.AddRange(Invis);
        }

        #endregion
    }
}