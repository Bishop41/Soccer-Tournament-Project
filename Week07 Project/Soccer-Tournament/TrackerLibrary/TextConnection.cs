using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection, IDisposable
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            throw new NotImplementException();
        }

        public void Dispose()
        {
            throw new NotImplementException();
        }
    }
}