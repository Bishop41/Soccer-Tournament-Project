using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentModel
{
    public class TournamentName { get; set; }
    public decimal EntryFee { get; set; }
    public List<TeamModel> Enter { get; set; } = new List<TeamModel>();
    public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
    public List<List<MatchupModel>> Rounds { get; set; } = new List<MatchupMode>();
