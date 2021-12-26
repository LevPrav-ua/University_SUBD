using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University_SUBD
{
    public partial class Entrant : Form
    {
        private NpgsqlConnection connection;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public Entrant()
        {
            InitializeComponent();
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Table.AutoResizeColumns();

            Table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Table.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            if (connect())
            {
                Console.WriteLine("Applicant Connected");
            }
            else
            {
                Connection.error("Не получается подключиться к базе");
                this.Close();
            }
        }

        public bool connect()
        {
            User user = new User("applicant", "applicant", "applicant");
            Database db = Connection.db;
            string connString = String.Format("Server={0};" +
                    "Port={1};" +
                    "Username={2};" +
                    "Password={3};" +
                    "Database={4}", db.Server, db.Port, user.name, user.password,
                    db.database);
            connection = new NpgsqlConnection(connString);
            try
            {
                //Открываем соединение.
                connection.Open();
                if (connection.FullState == ConnectionState.Broken)
                {
                    throw new Exception("Connection broken");
                    //Тут меняем что-то в своей жизни, но я обычно выбрасываю исключение, чтобы не искать в коде миллион лет, что сломалось.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }


        private void fillTable(string sql)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection); ;
            ds.Reset();
            adapter.Fill(ds);
            dt = ds.Tables[0];
            Table.DataSource = dt;
        }

        private void entrants_Click(object sender, EventArgs e)
        {
            string sql = ("SELECT faculty as Факультет, lastName as Фамилия , firstname as Имя , " +
                "middleName as Отчество,  " +
                "groupnumber as \"Номер группы\" " + 
                " from entrant, faculties " +
                "where entrant.facultyid = faculties.facultyid " +
                "order by Факультет");
            fillTable(sql);
        }
        private void faculty_Click(object sender, EventArgs e)
        {
            string sql = ("SELECT faculty as Факультет from faculties");
            fillTable(sql);
        }
        private void exams_Click(object sender, EventArgs e)
        {
            string sql = ("SELECT facultyname as Факультет, firstexam as \"Первый экз\", " +
                "secondexam as \"Второй экз\" , thirdexam as \"Третий экз\" "  +
                " from exams");
            fillTable(sql);
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            string sql = ("SELECT id, streamname as Поток, examname as Экзамен , dateofconsultation as \"Дата консультации\", " +
                "dateofexam as \"Дата экзамена\", classroomnumber as Аудитория " +
                " from schedule");
            fillTable(sql);
        }

        private void cathedras_Click(object sender, EventArgs e)
        {
            string sql = ("select faculty as Факультет , cathedraname as Кафедра from faculties, cathedra " +
                "where cathedra.facultyid = faculties.facultyid");
            fillTable(sql);
        }

        private void stream_Click(object sender, EventArgs e)
        {
            string sql = ("SELECT groupnumber as \"Номер группы\", " +
                "streamname as \"Поток\" from stream");
            fillTable(sql);
        }

        private void group_exams_Click(object sender, EventArgs e)
        {
            if (group_num.Text == "")
            {
                Connection.error("Введите номер группы");
                return;
            }
            int group = Convert.ToInt32(group_num.Text);
            if (group < 10)
            {
                Connection.error("Некорректный номер группы");
                return;
            }

            string sql = "select examname as Экзамен , dateofconsultation as \"Дата консультации\", " +
                "dateofexam as \"Дата экзамена\", classroomnumber as Аудитория, " +
                "groupnumber as \"Номер группы\" from schedule " +
                "right join stream s on schedule.streamName = s.streamName " +
                "where s.groupNumber = " + group;

            fillTable(sql);
        }
    }
}
