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
            WorkConsole wc = new WorkConsole();
            DefaultConfig dc = new DefaultConfig();

            //configurate SUBD --------------------------------------------

            Connection.db = dc.db;

            /*-------------------------------------------------------------*/

            if (!wc.start())
            {
                throw new Exception("Cant open console");
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            /*string connString =
                "Server=localhost;" +
                "Port=5435;" +
                "Username=postgres;" +
                "Password=postgres;" +
                "Database=admissionCommittee";*/


            //NpgsqlConnection nc = new NpgsqlConnection(connString);
            /*try
            {
                //��������� ����������.
                nc.Open();
                if (nc.FullState == ConnectionState.Broken)
                {
                    throw new Exception("Connection broken");
                    //��� ������ ���-�� � ����� �����, �� � ������ ���������� ����������, ����� �� ������ � ���� ������� ���, ��� ���������.
                }
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT * from entrant", nc);
                //int rows_changed = npgc.ExecuteNonQuery();//���� ������ �� ���������� �������
                //NpgsqlDataReader ndr = npgc.ExecuteReader();//���� ������ ���������� �������

                NpgsqlDataReader reader = npgc.ExecuteReader();
                if (reader.HasRows)//���� ������ ����������
                {
                    while (reader.Read())//���� ���� ������
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write(reader.GetValue(i).ToString() + " ");//�������� ������ � ��������� � � ������
                        }
                        Console.WriteLine("\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            wc.stop();
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

