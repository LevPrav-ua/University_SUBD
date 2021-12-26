using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;
using System.Runtime.InteropServices;


namespace University_SUBD
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DefaultConfig dc = new DefaultConfig();

            //configurate SUBD --------------------------------------------

            Connection.db = dc.db;

            /*-------------------------------------------------------------*/

            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChooseUser());


        }

        public class WorkConsole
        {
            private bool work = false; 

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();

            public bool start()
            {
                work = AllocConsole();
                return work;
            }
            public void stop()
            {
                if (work) Console.ReadKey();
            }
        }
    }
}

