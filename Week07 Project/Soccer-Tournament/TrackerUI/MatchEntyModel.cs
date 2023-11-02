sing System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class matchupEntryModel
    {
        /// <summary>
        /// Representing team in matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represent the score for this particular team. 
        /// </summary>
        public double Score { get; set; }
        public matchupEntryModel Parentmatchup { get; set;}
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// </param>

        public matchupEntryModel(double initialScore)
        {
            global::System.Object value = Console.WriteLine();

        }
    }