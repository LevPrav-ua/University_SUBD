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
    public partial class employee : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public employee()
        {
            InitializeComponent();
        }

        private void entrant_Click(object sender, EventArgs e)
        {

            string sql = ("SELECT * from entrant");
            NpgsqlDataAdapter adapter = Connection.request_adapter(sql);
            ds.Reset();
            adapter.Fill(ds);
            dt = ds.Tables[0];
            Table.DataSource = dt;
            add.Enabled = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            int last_id = Convert.ToInt32(Table[0, Table.RowCount - 2].Value.ToString());
            Form addAbitur = new add_Abitur(last_id);
            addAbitur.Show();
        }
    }
}
