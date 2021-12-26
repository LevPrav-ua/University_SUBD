using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University_SUBD
{
    public partial class ChooseUser : Form
    {
        Form empl, entr;
        public ChooseUser()
        {
            InitializeComponent();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            empl = new Form1();
            empl.Show();
            employee.Enabled = false;
        }

        private void entrant_btn_Click(object sender, EventArgs e)
        {
            entrant_btn.Enabled = false;
            entr = new Entrant();
            entr.Show();
        }
    }
}
