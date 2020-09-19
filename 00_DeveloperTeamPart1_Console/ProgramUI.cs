using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Text;

namespace _00_DeveloperTeamPart1_Console
{
    class ProgramUI
    {
        public class TeamInfoRepository _infoRepo = new TeamInfoRepository();
        
        //Method that starts the UI part of the application
        public void Run()
        {
            TeamInfoList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to the user

                Console.WriteLine("Select a Menu Option /n" +
                    "1. View Existing Teams /n" +
                    "2. Create a Team /n" +
                    "3. Get Team Information by ID /n" +
                    "4. Delete a team by ID /n" +
                    "5. Exit");

                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly

                switch (input)
                {
                    case "1":
                        //View Exisiting Teams
                        DisplayAllTeams();
                    case "2":
                        //Create new Team
                        CreateNewTeam();
                        break;
                    case "3":
                        //Display be Team ID
                        DisplayById();
                        break;
                    case "4":
                        //Delete a team by ID
                        DeleteById();
                        break;                        
                }
                Console.WriteLine("Press any dey to continue...");
                Console.ReadLine();
                Console.Clear();              
            }

            //private void DisplayAllTeams()
            //{
            //    Console.Clear();

            //    List<TeamInfo> listOfTeams = _infoRepo.GetTeamInfo
            //}
        }

        private void SeedContentList()
        {
            TeamInfo
        }          


    }
}
