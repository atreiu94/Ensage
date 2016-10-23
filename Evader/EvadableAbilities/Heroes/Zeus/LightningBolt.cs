﻿namespace Evader.EvadableAbilities.Heroes.Zeus
{
    using Base;

    using Ensage;

    using static Data.AbilityNames;

    internal class LightningBolt : LinearAOE
    {
        #region Constructors and Destructors

        public LightningBolt(Ability ability)
            : base(ability)
        {
            BlinkAbilities.Clear();
            DisableAbilities.Clear();

            CounterAbilities.Add(PhaseShift);
            CounterAbilities.Add(BallLightning);
            CounterAbilities.Add(Eul);
            CounterAbilities.Add(SleightOfFist);
            CounterAbilities.Add(Manta);
            CounterAbilities.AddRange(VsDamage);
            CounterAbilities.AddRange(VsMagic);
            CounterAbilities.Add(Lotus);
            CounterAbilities.Add(NetherWard);
            CounterAbilities.AddRange(Invis);
        }

        #endregion
    }
}