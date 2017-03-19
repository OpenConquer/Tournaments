using System;
using System.Collections.Generic;
using OpenConquer.Network.GamePackets;

namespace OpenConquer.Game.Models.Tournaments
{
    /// <summary>
    /// Model for a tournament reward.
    /// </summary>
    public sealed class TournamentReward
    {
        /// <summary>
        /// Gets or sets the money.
        /// </summary>
        public uint Money { get; set; }

        /// <summary>
        /// Gets or sets the conquer points.
        /// </summary>
        public uint ConquerPoints { get; set; }

        /// <summary>
        /// Gets or sets the bound cps.
        /// </summary>
        public uint BoundCPs { get; set; }

        /// <summary>
        /// Gets a list of items.
        /// </summary>
        public List<ConquerItem> Items { get; private set; }

        /// <summary>
        /// Creates a new tournament reward.
        /// </summary>
        public TournamentReward()
        {
            Items = new List<ConquerItem>();
        }
    }
}
