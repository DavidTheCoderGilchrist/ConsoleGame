using _00_DeveloperTeamPart1_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace _00_DeveloperTeamPart1
{
    public class TeamInfoRepository
    {
        public List<TeamInfo> _listofTeamInfo = new List<TeamInfo>();

        //Create New Member by ID
        public void AddNewMemberByID(TeamInfo member)
        {
            _listofTeamInfo.Add(member);
        }

        //(READ)
        public List<TeamInfo> GetTeamInfo()
        {
            return _listofTeamInfo;
        }

        //(UPDATE)

        //Remove/Delete Members by their ID

        //Helper Method
        private TeamInfo GetTeamInfoByID (string id)
        {
            foreach (TeamInfo member in _listofTeamInfo)
            {
                if (member.Id == id)
                {
                    return member;
                }
                else
                {
                    return null;
                }
            }        
        }


    }
}
