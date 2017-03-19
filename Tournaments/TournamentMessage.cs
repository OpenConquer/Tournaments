using System;

namespace COServer.Game.Models.Tournaments
{
    /// <summary>
    /// all Message.
    /// </summary>
    public static class TournamentMessage
    {
        
        #region Tournament Messages
        public const string TOURNAMENT_LEVEL_TOO_LOW =
            "Your level is not high enough to join this tournament.";

        public const string TOURNAMENT_REBORNS_TOO_LOW =
            "You do not have enough reborns to join this tournament.";

        public const string TOURNAMENT_NOT_VIP =
            "You must be a VIP to join this tournament.";

        public const string TOURNAMENT_NOT_FEMALE =
            "You must be a female to join this tournament.";

        public const string TOURNAMENT_NOT_MALE =
            "You must be a male to join this tournament.";

        public const string TOURNAMENT_NO_GUILD =
            "You must be in a guild to join this tournament.";

        public const string TOURNAMENT_NOT_GUILD_LEADER_OR_DEPUTY_LEADER =
            "You must be the guild- or deputy leader to join this tournament.";

        public const string TOURNAMENT_NOT_GUILD_LEADER =
            "You must be the guild leader to join this tournament.";

        public const string TOURNAMENT_NOT_DEPUTY_LEADER =
            "You must be the deputy leader to join this tournament.";

        public const string TOURNAMENT_SIGNED_UP =
            "You have been signed up for {0}";

        public const string TOURNAMENT_SEND =
            "{0} has begun! Good luck to all players.";

        public const string TOURNAMENT_END =
            "{0} has ended.";

        public const string TOURNAMENT_END_WINNER =
            "{0} has ended and the winner was {1}.";
        #endregion
    }
}
