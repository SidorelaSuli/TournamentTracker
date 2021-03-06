﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        private const string dbName = "Tournaments";

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();

                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("EmailAddress", model.EmailAddress);
                p.Add("CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // specific for operations where nothing is returned from the database
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                // the model will have the Id = the id of the row just inserted in the Prizes table
                // that's wht id is an output parameter
                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including hte unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            // connect to SQl Server
            
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();

                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // specific for operations where nothing is returned from the database
                conn.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                // the model will have the Id = the id of the row just inserted in the Prizes table
                // that's wht id is an output parameter
                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        /// <summary>
        /// Insert every team member from a team in the TeamMembers table
        /// </summary>
        /// <param name="model">The team information</param>
        /// <returns>A Team model</returns>
        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                // insert the new team in the Teams table
                var p = new DynamicParameters();

                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);

                conn.Execute("dbo.spTeamsInsert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                // insert each team member(Person instance) in the TeamMembers table
                foreach (PersonModel teamMember in model.TeamMembers)
                {
                    p = new DynamicParameters();

                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", teamMember.Id);

                    conn.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }

        /// <summary>
        /// Insert a tournament in the database/text file
        /// Insert all of the prizes ids in the database/text file
        /// Insert all of the teams ids in the database/text file
        /// </summary>
        /// <returns>A TournamentModel</returns>
        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                // insert the tournament's name and entry fee into the Tournaments table
                SaveTournament(conn, model);

                // insert the tournament's prizes in the TournamentPrizes table
                SaveTournamentPrizes(conn, model);

                // insert the tournament's teams in the TournamentEntries table
                SaveTournamentEntries(conn, model);

                SaveTouramentRounds(conn, model);

            }
        }

        /// <summary>
        /// Insert the tournament's name and entry fee into the Tournaments table
        /// </summary>
        /// <param name="model"></param>
        private void SaveTournament(IDbConnection conn, TournamentModel model)
        {
            var p = new DynamicParameters();

            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

            conn.Execute("dbo.Tournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
        }

        /// <summary>
        /// Insert the tournament's prize ids in the TournamentPrizes table
        /// </summary>
        /// <param name="conn">The connection to the database</param>
        /// <param name="model">The TournamentModel you want to insert</param>
        private void SaveTournamentPrizes(IDbConnection conn, TournamentModel model)
        {
            foreach (PrizeModel prize in model.Prizes)
            {
                var p = new DynamicParameters();

                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", prize.Id);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Insert the tournament's team ids in the TournamentEntries table
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="model"></param>
        private void SaveTournamentEntries(IDbConnection conn, TournamentModel model)
        {
            foreach (TeamModel team in model.EnteredTeams)
            {
                var p = new DynamicParameters();

                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", team.Id);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void SaveTouramentRounds(IDbConnection conn, TournamentModel model)
        {
            // List<List<MatchupModel>> Rounds
            // List<MatchupEntryModel> Entries

            // Loop through the rouds
            foreach (List<MatchupModel> round in model.Rounds)
            {
                // Loop through the matchups
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();

                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                    // Save the matchup
                    conn.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@id");

                    // Loop through the entries and save them
                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();

                        p.Add("@MatchupId", matchup.Id);

                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
                        }

                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        }

                        p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                        // Save the matchup entry
                        conn.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                    }

                }
            }
        }

        /// <summary>
        /// Gets all Person data from the Tournaments database
        /// </summary>
        /// <param name="model">The person information.</param>
        /// <returns>A list of PesonModel instances from the Tournaments database</returns>
        public List<PersonModel> GetPersonAll()
        {
            List<PersonModel> output;

            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = conn.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        /// <summary>
        /// Get all the teams from the database or from a text file
        /// </summary>
        /// <returns>A list of teams</returns>
        public List<TeamModel> GetTeamAll()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();

                    p.Add("@TeamId", team.Id);

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }

            return output;
        }

        public PrizeModel Create(PrizeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
