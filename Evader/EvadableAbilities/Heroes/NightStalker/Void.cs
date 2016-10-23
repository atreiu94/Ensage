﻿namespace Evader.EvadableAbilities.Heroes.NightStalker
{
    using Base;

    using Ensage;

    using static Data.AbilityNames;

    internal class Void : LinearTarget
    {
        #region Constructors and Destructors

        public Void(Ability ability)
            : base(ability)
        {
            CounterAbilities.Add(PhaseShift);
            CounterAbilities.AddRange(VsDamage);
            CounterAbilities.AddRange(VsMagic);
            CounterAbilities.Add(Lotus);
        }

        #endregion
    }
}