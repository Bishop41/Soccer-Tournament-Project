using System;
using System.Collection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        
        public PrizeModel CreatePrize(PrizeModel model)
        {
            throw new NotImplementException();
        }

        public PrizeModel CreatePrize2(PrizeModel mode)
        {
           using (IDbConnection connect = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
           {
            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PlaceNumber);
            p.Add("@Placename",model.PlaceName);
            p.Add("@PrizeAmount", model.PrizeAmount);
            p.Add("@PricePercentage", model.PricePercentage);
            p.Add("@id",0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connect.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
            
           }

            return model;
        }
    }
}