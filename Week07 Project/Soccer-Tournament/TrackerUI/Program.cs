using System;
using System.Collection.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Window.Form;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TournamentDashboardForm());

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);
            Application.Run(new CreatePrizeform());
            
            //Application.Run(new TournamentDashboardForm());
        }
    }
}