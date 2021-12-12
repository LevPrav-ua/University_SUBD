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
    public partial class add_Abitur : Form
    {
        Dictionary<string, string> fac_id = new Dictionary<string, string>();
        Dictionary<string, List<string>> cath_id = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> group_id = new Dictionary<string, List<string>>();
        public add_Abitur()
        {
            InitializeComponent();

            string sql = ("SELECT facultyid, faculty from faculties");

            NpgsqlDataReader reader = Connection.request_reader(sql);
            List<string> facs = new List<string>();

            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Пока есть записи
                {
                    fac_id[reader.GetValue(1).ToString()]  = reader.GetValue(0).ToString();
                    facs.Add(reader.GetValue(1).ToString());
                }
            }
            reader.Close();

            sql = ("SELECT facultyid, cathedraname from cathedra");
            reader = Connection.request_reader(sql);
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Пока есть записи
                {
                    string key = reader.GetValue(0).ToString();
                    if (!cath_id.ContainsKey(key))
                    {
                        cath_id[key] = new List<string>();
                    }
                    cath_id[key].Add( reader.GetValue(1).ToString());
                }
            }
            reader.Close();

            sql = ("SELECT groupnumber from stream");
            reader = Connection.request_reader(sql);
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Пока есть записи
                {
                    string group = reader.GetValue(0).ToString();
                    string f_id = group[0].ToString();
                    List<string> caths = cath_id[f_id];
                    if ((group[1] - 48) % 2 == 1)
                    {
                        if (!group_id.ContainsKey(caths[0]))
                        {
                            group_id[caths[0]] = new List<string>();
                        }
                        group_id[caths[0]].Add(group);
                    }
                    else
                    {
                        if (!group_id.ContainsKey(caths[1]))
                        {
                            group_id[caths[1]] = new List<string>();
                        }
                        group_id[caths[1]].Add(group);
                    }
                }
            }
            reader.Close();

            faculty.Items.AddRange(facs.ToArray());
        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cathedra.Text = "";
            group.Text = "";
            cathedra.Items.Clear();
            group.Items.Clear();
            cathedra.Items.AddRange(cath_id[fac_id[faculty.SelectedItem.ToString()]].ToArray());
        }

        private void cathedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            group.Text ="";
            group.Items.Clear();
            group.Items.AddRange(group_id[cathedra.SelectedItem.ToString()].ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cmd = new NpgsqlCommand("INSERT INTO entrant VALUES (@pass, @surname, @name, @second_name," +
                "@f_id, @group)", Connection.connection))
            {
                try
                {
                    if ( passport.Text == "" || surname.Text == ""
                        || name.Text == "" ||second_name.Text == "" || 
                        faculty.Text == "" || group.Text == "")
                    {
                        throw new Exception("Заполните поля");
                    }
                    cmd.Parameters.AddWithValue("pass", passport.Text);
                    cmd.Parameters.AddWithValue("surname", surname.Text);
                    cmd.Parameters.AddWithValue("name", name.Text);
                    cmd.Parameters.AddWithValue("second_name", second_name.Text);
                    cmd.Parameters.AddWithValue("f_id", Convert.ToInt32(fac_id[faculty.SelectedItem.ToString()]));
                    cmd.Parameters.AddWithValue("group", Convert.ToInt32(group.SelectedItem.ToString()));

               
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        Connection.success("Абитуриент успешно добавлен");
                    }
                }
                catch (Exception err)
                {
                    Connection.error(err.Message);
                    return;
                }
            }
            using (var cmd = new NpgsqlCommand("insert into examlist(entrantPassport, " +
                "firstmark, secondmark, thirdmark)" +
                " values (@passport, 2, 2, 2) ", Connection.connection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("passport", passport.Text);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        Connection.success("Абитуриент успешно добавлен в список экзаменов");
                        clean();

                    }
                }
                catch (Exception ex)
                {
                    Connection.error(ex.Message);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clean()
        {
            passport.Text = "";
            surname.Text = "";
            name.Text = "";
            second_name.Text = "";
            faculty.Text = "";
            group.Text = "";
            cathedra.Text = "";
        }
    }
}
