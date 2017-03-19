using System;

namespace OpenConquer.Game.Models.Tournaments
{
    /// <summary>
    /// Model for tournament sign up response.
    /// </summary>
    public sealed class TournamentSignUpResponse
    {
        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets a boolean determining whether player can sign up.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// Creates a new tournament sign up response.
        /// </summary>
        private TournamentSignUpResponse() { }

        /// <summary>
        /// Handles the sign up validation for a player.
        /// </summary>
        /// <param name="tournament">The tournament.</param>
        /// <param name="player">The player.</param>
        /// <returns>The response.</returns>
        public static TournamentSignUpResponse SignUp(ITournamentBase tournament, Client.GameState player)
        {
            string _message = string.Empty;

            if (player.Entity.Level < tournament.RequiredLevel)
            {
                _message = TournamentMessage.TOURNAMENT_LEVEL_TOO_LOW;
            }

            if (player.Entity.Reborn < tournament.RequiredReborns)
            {
                _message = TournamentMessage.TOURNAMENT_REBORNS_TOO_LOW;
            }

            if (tournament.RequiredToBeVIP && player.Entity.VIPLevel == 0)
            {
                _message = TournamentMessage.TOURNAMENT_NOT_VIP;
            }

            if (tournament.RequiredToBeFemale && !player.Entity.IsFemale)
            {
                _message = TournamentMessage.TOURNAMENT_NOT_FEMALE;
            }
            else if (tournament.RequiredToBeMale && !player.Entity.IsMale)
            {
                _message = TournamentMessage.TOURNAMENT_NOT_MALE;
            }

            if (tournament.RequiredGuild && player.Entity.GuildID == null)
            {
                _message = TournamentMessage.TOURNAMENT_NO_GUILD;
            }
            else if (tournament.RequiredGuild)
            {
                if (tournament.RequiredGuildLeader && tournament.RequiredDeputyLeader &&
                    player.Entity.GuildRank != (ushort)Enums.GuildMemberRank.GuildLeader &&
                    player.Entity.GuildRank != (ushort)Enums.GuildMemberRank.DeputyLeader)
                {
                    _message = TournamentMessage.TOURNAMENT_NOT_GUILD_LEADER_OR_DEPUTY_LEADER;
                }
                else if (tournament.RequiredGuildLeader && player.Entity.GuildRank != (ushort)Enums.GuildMemberRank.GuildLeader)
                {
                    _message = TournamentMessage.TOURNAMENT_NOT_GUILD_LEADER;
                }
                else if (tournament.RequiredDeputyLeader && player.Entity.GuildRank != (ushort)Enums.GuildMemberRank.DeputyLeader)
                {
                    _message = TournamentMessage.TOURNAMENT_NOT_DEPUTY_LEADER;
                }
            }

            bool _success = string.IsNullOrWhiteSpace(_message);
            if (_success)
            {
                _message = TournamentMessage.TOURNAMENT_SIGNED_UP;
            }

            return new TournamentSignUpResponse
            {
                Message = _message,
                Success = _success
            };
        }
    }
}
