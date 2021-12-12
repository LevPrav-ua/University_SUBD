using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace University_SUBD
{
    public partial class employee : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        int current_row = -1;
        int table_id = -1;
        public employee()
        {
            InitializeComponent();
            current_line_text.ReadOnly = true;
            Table.AutoSizeColumnsMode =  DataGridViewAutoSizeColumnsMode.AllCells;
            Table.AutoResizeColumns();

            Table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Table.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            buttons_set(false);
        }

        private void entrant_Click(object sender, EventArgs e)
        {
            Table.ReadOnly = false;
            string sql = ("SELECT * from entrant");
            NpgsqlDataAdapter adapter = Connection.request_adapter(sql);
            ds.Reset();
            adapter.Fill(ds);
            dt = ds.Tables[0];
            Table.DataSource = dt;
            Table.Columns[0].ReadOnly = true;
            buttons_set(true);
            table_id = 1;
        }

        private void add_Click(object sender, EventArgs e)
        {
           //int last_id = Convert.ToInt32(Table[0, Table.RowCount - 2].Value.ToString());
            Form addAbitur = new add_Abitur();
            addAbitur.Show();
        }


        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Console.WriteLine(e.RowIndex);
            current_row = e.RowIndex;
            current_line_text.Text = (current_row+1).ToString();
        }

        private void buttons_set(bool state)
        {
            add.Enabled = state;
            delete.Enabled = state;
            update.Enabled = state;
            reference.Enabled = state;
            report.Enabled = state;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM entrant WHERE passport = @pass;";

            using (var cmd = new NpgsqlCommand(sql, Connection.connection))
            {
                try
                {
                    string pass = Table[0, current_row].Value.ToString();
                    cmd.Parameters.AddWithValue("pass", pass);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        Connection.success("Абитуриент успешно удалён");
                    }
                    Table.Rows.RemoveAt(current_row); //по индексу строки удаляем
                    Console.WriteLine("deleted passport " + pass);
                    current_row = -1;
                    current_line_text.Text = "-1";
                }
                catch (Exception ex)
                {
                    Connection.error(ex.Message);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            switch (table_id)
            {
                case 1:
                    update_entrant();
                    break;
                case 3:
                    update_exam();
                    break;
                default:
                    break;
            }
        }

        private void faculty_Click(object sender, EventArgs e)
        {
            buttons_set(false);
            string sql = ("SELECT * from faculties");
            NpgsqlDataAdapter adapter = Connection.request_adapter(sql);
            ds.Reset();
            adapter.Fill(ds);
            dt = ds.Tables[0];
            Table.DataSource = dt;
            Table.ReadOnly = true;
            table_id = 2;
        }

        private void update_entrant()
        {
            string sql = "update entrant set lastname = @l_name, " +
                "firstname = @f_name, middlename = @m_name," +
                "facultyid = @f_id, groupnumber = @group where passport= @pass; ";

            using (var cmd = new NpgsqlCommand(sql, Connection.connection))
            {
                try
                {
                    string passport = Table[0, current_row].Value.ToString();
                    string surname = Table[1, current_row].Value.ToString();
                    string name = Table[2, current_row].Value.ToString();
                    string second_name = Table[3, current_row].Value.ToString();
                    int f_id = Convert.ToInt32(Table[4, current_row].Value.ToString());
                    int group = Convert.ToInt32(Table[5, current_row].Value.ToString());

                    if (surname == "" || name == ""
                        || second_name == "" ||
                            f_id == 0 || group == 0)
                    {
                        throw new Exception("Заполните поля");
                    }
                    cmd.Parameters.AddWithValue("pass", passport);
                    cmd.Parameters.AddWithValue("l_name", surname);
                    cmd.Parameters.AddWithValue("f_name", name);
                    cmd.Parameters.AddWithValue("m_name", second_name);
                    cmd.Parameters.AddWithValue("f_id", f_id);
                    cmd.Parameters.AddWithValue("group", group);

                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        Connection.success("Данные абитуриента изменены");
                    }
                }
                catch (Exception ex)
                {
                    Connection.error(ex.Message);
                }
            }
        }

        private void exams_Click(object sender, EventArgs e)
        {
            buttons_set(false);
            string sql = ("SELECT * from examlist");
            NpgsqlDataAdapter adapter = Connection.request_adapter(sql);
            ds.Reset();
            adapter.Fill(ds);
            dt = ds.Tables[0];
            Table.DataSource = dt;
            Table.ReadOnly = false;
            Table.Columns[0].ReadOnly = true;
            Table.Columns[1].ReadOnly = true;
            table_id = 3;
            update.Enabled = true;
        }

        private void update_exam()
        {
            string sql = "update examlist set firstmark = @f_mark, " +
                "secondmark = @s_mark, thirdmark = @t_mark " +
                "where examlistnumber = @el_num ";

            using (var cmd = new NpgsqlCommand(sql, Connection.connection))
            {
                try
                {
                    int el_num = Convert.ToInt32(Table[0, current_row].Value.ToString());
                    int f_mark = Convert.ToInt32(Table[2, current_row].Value.ToString());
                    int s_mark = Convert.ToInt32(Table[3, current_row].Value.ToString());
                    int t_mark = Convert.ToInt32(Table[4, current_row].Value.ToString());

                    if (f_mark < 1 || s_mark < 1 || t_mark < 1 ||
                        f_mark > 5 || s_mark > 5 || t_mark > 5)
                    {
                        throw new Exception("Оценка выставляется от 1 до 5");
                    }
                    cmd.Parameters.AddWithValue("el_num", el_num);
                    cmd.Parameters.AddWithValue("f_mark", f_mark);
                    cmd.Parameters.AddWithValue("s_mark", s_mark);
                    cmd.Parameters.AddWithValue("t_mark", t_mark);

                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        Connection.success("Данные абитуриента изменены");
                    }
                }
                catch (Exception ex)
                {
                    Connection.error(ex.Message);
                }
            }
        }

        private void reference_Click(object sender, EventArgs e)
        {
            buttons_set(false);
            if(current_row == -1)
            {
                Connection.error("Выберете абитуриента");
                return;
            }

            string passport = Table[0, current_row].Value.ToString();
            string surname = Table[1, current_row].Value.ToString();
            string name = Table[2, current_row].Value.ToString();
            string second_name = Table[3, current_row].Value.ToString();
            string f_id = Table[4, current_row].Value.ToString();
            string f_name = ""; 

            NpgsqlCommand npgc = new NpgsqlCommand("SELECT faculty from faculties " +
                "where facultyid = " + f_id, Connection.connection);
           
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Пока есть записи
                {
                    f_name = reader.GetString(0);
                }
            }
            reader.Close();

            string file_name = "справка_" + passport + ".txt";

            string refer = String.Format("Справка выдана о том, что {0} {1} {2}, " +
                "паспорт: {3}, действительно поступает на {4}.\n" +
                "Справка выдана: {5}", 
                surname, name, second_name, passport, f_name,
                DateTime.Now.ToShortDateString());

            FileStream fs = create_file(file_name);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(refer); //что-то пишем
            writer.Close();

            buttons_set(true);
        }

        private FileStream create_file(string file_name)
        {
            string currentPath = Directory.GetCurrentDirectory();
            if (!Directory.Exists(Path.Combine(currentPath, "Отчёты")))
                Directory.CreateDirectory(Path.Combine(currentPath, "Отчёты"));

            string path = Path.Combine(currentPath, "Отчёты\\");
            return File.Create(path + file_name);
        }

        private void report_Click(object sender, EventArgs e)
        {
            buttons_set(false);

            FileStream file = create_file("report.txt");
            StreamWriter writer = new StreamWriter(file);

            string sql = "select faculty, count(passport) as number_of_entrants from entrant " +
                "left join faculties f on entrant.facultyId = f.facultyId " +
                "group by faculty ";

            NpgsqlCommand npgc = new NpgsqlCommand(sql, Connection.connection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                writer.WriteLine("------------------------------------------------------------------");
                writer.WriteLine("Факультет".PadRight(40) + " | Колличество студентов |");
                writer.WriteLine("------------------------------------------------------------------");
                while (reader.Read())//Пока есть записи
                {
                    writer.Write(reader.GetValue(0).ToString().PadRight(40) + " | ");
                    writer.Write(reader.GetValue(1).ToString().PadRight(21) + " | ");
                    writer.Write("\n");
                }
                writer.WriteLine("------------------------------------------------------------------");
                writer.Write("\n\n");
            }
            reader.Close();

            sql = "select groupnumber, count(passport) as number_of_entrants_in_group from entrant" +
                " group by groupnumber ";
            npgc = new NpgsqlCommand(sql, Connection.connection);
            reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine("Группа".PadRight(6) + "| Колличество студентов |");
                writer.WriteLine("-------------------------------");
                while (reader.Read())//Пока есть записи
                {
                    writer.Write(reader.GetValue(0).ToString().PadRight(5) + " | ");
                    writer.Write(reader.GetValue(1).ToString().PadRight(21) + " | ");
                    writer.Write("\n");
                }
                writer.WriteLine("-------------------------------");
                writer.Write("\n\n");
            }
            reader.Close();

            sql = "select examname, streamName, dateOfConsultation, dateOfExam, classroomNumber from schedule " +
                "ORDER BY examname";
            npgc = new NpgsqlCommand(sql, Connection.connection);
            reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                writer.WriteLine("--------------------------------------------------------------------------------");
                writer.WriteLine("Экзамен".PadRight(20) + " |  Поток  | Дата консультации | Дата экзамена | Аудитория |");
                writer.WriteLine("--------------------------------------------------------------------------------");
                while (reader.Read())//Пока есть записи
                {
                    writer.Write(reader.GetValue(0).ToString().PadRight(20) + " | ");
                    writer.Write(reader.GetValue(1).ToString() + " | ");
                    writer.Write(reader.GetValue(2).ToString().Split(' ')[0].PadRight(17) + " | ");
                    writer.Write(reader.GetValue(3).ToString().Split(' ')[0].PadRight(13) + " | ");
                    writer.Write(reader.GetValue(4).ToString().PadRight(9) + " | ");
                    writer.Write("\n");
                }
                writer.WriteLine("--------------------------------------------------------------------------------");
                writer.Write("\n\n");
            }
            reader.Close();

            Dictionary<string, int[]> subject = new Dictionary<string, int[]>();

            sql = "select entrant.passport, examname,  stream.groupnumber, " +
                "firstmark, secondmark, thirdmark " +
                "from schedule, stream, entrant, examlist " +
                "where schedule.streamname = stream.streamname and entrant.groupnumber = stream.groupnumber " +
                "and examlist.entrantpassport = entrant.passport " +
                "order by passport";
            npgc = new NpgsqlCommand(sql, Connection.connection);
            reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                int line = 0;
                while (reader.Read())//Пока есть записи
                {
                    string key = reader.GetValue(1).ToString();
                    if (!subject.ContainsKey(key))
                    {
                        subject[key] = new int[4];
                    }
                    int mark = Convert.ToInt32(reader.GetValue(3 + (line % 3)).ToString());
                    if (mark > 2)
                    {
                        subject[key][mark - 2] += 1;
                        line++;
                    }
                }
            }

            writer.WriteLine("--------------------------------------");
            writer.WriteLine("Название предмета".PadRight(20) + " | 2 | 3 | 4 | 5 |");
            writer.WriteLine("--------------------------------------");
            foreach (string key in subject.Keys)
            {
                writer.Write(key.PadRight(20) + " |");
                for(int i = 0; i < 4; i++)
                {
                    writer.Write(" " + subject[key][i] + " |");
                }
                writer.Write("\n");
            }
            writer.WriteLine("--------------------------------------");
            writer.Write("\n\n");
            reader.Close();

            writer.Close();
            file.Close();
            Table.ReadOnly = true;
        }
    }
}
