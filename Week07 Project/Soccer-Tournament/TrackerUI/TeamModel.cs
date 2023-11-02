using System;
using Sytem.Collection.Generic;
using System.Linnq;
using System.Text;
using System.Threading.Tasks;

namespace TreckerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonMode>();
        public string TeamName { get; set; }

        public TeamModel()
        {
            TeamMembers = new List<Person>();
        }
    }
}