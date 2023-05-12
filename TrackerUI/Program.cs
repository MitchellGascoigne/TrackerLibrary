namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

            Application.Run(new TournamentDashboardForm());
        }
    }
}