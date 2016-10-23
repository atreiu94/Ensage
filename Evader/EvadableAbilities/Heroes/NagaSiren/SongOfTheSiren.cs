﻿namespace Evader.EvadableAbilities.Heroes.NagaSiren
{
    using Base;

    using Ensage;

    using static Data.AbilityNames;

    internal class SongOfTheSiren : AOE
    {
        #region Constructors and Destructors

        public SongOfTheSiren(Ability ability)
            : base(ability)
        {
            //todo ignore remaining time ?
            BlinkAbilities.AddRange(BlinkAbilityNames);
            DisableAbilities.AddRange(DisableAbilityNames);
        }

        #endregion
    }
}