using System.Windows.Forms;
using System.IO;
using System;

namespace ProjectSentinel
{
    static class Program
    {
        /// <summary>
        /// Welcome to Project Sentinel v0.1! We've been procrastinating on developing it for a long time, but we're doing our best to make up for it.
        /// We like spaghetti, so we made spaghetti code. *wink* *wink* *StaringImploringly*
        /// </summary>
    static void Main()
        {
            if(Properties.Settings.Default.ApplicationFirstRun)
            {
                DefaultDatabaseValues.fillDatabaseWithDefaultInstitutionAddresses();
                DefaultDatabaseValues.fillDatabaseWithDefaultInstituions();
                Properties.Settings.Default.ApplicationFirstRun = false;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.UserLoggedInBetweenSessions) {Application.Run(new MainScreenActivity(/*user*/));}
            else {Application.Run(new LoginActivity());}
        }
    }
}
