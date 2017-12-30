using System;
using System.Windows.Forms;
using Selma.DataAccess;

namespace Selma.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain(new CandidateInfoRepository(), new InstructorRepository()));
            }
            catch (Exception e)
            {
                Helper.Logger.Fatal($"Unexpected error: {e.Message}{Environment.NewLine}{e}");
            }   
        }
    }
}
