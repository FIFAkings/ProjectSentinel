using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSentinel
{
    static class Program
    {
        /// <summary>
        /// Welcome to Project Sentinel v0.1! We've been procrastinating on developing it for a long time, but we're doing our best to make up for it.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Properties.Settings.Default.ApplicationFirstRun)
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
