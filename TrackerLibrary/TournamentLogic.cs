using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TournamentLogic
    {

        /// <summary>
        /// Create the rounds
        /// </summary>
        /// <param name="model"></param>
        public static void CreateRounds(TournamentModel model)
        {
            // Order our list of teams randomly
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);

            // number of rounds based of the number of teams in the tournament
            int rounds = FindNumberOfRounds(randomizedTeams.Count);

            // byeTeam = dummy team that competes against one team.
            // Used when the number of teams is odd
            int byes = NumberOfByeTeams(rounds, randomizedTeams.Count);

            // Create our first round of matchups
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            // Create every round after that - 8 teams 4 matchups => 4 teams 2 matchups = 2 teams 1 matchup => winner
            CreateOtherRounds(model, rounds);
        }
    }
}
