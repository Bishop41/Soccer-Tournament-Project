using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections(string connectionType)
        {
            if (connectionType == "sql")
            {
                //ToDo -  Set Up The SQI Connector properly
                SqIconnector sql = new SqlConnector();
                InitializeConnections.Add(sql);
                
            }
            else if (connectionType == "text")
            {
                // Create the text Connection.
                TextConnection text =  new TextConnection();
                Connections = (text);
            }
        }
        public static string CnnString(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionStrings;
    }
}