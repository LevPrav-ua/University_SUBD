using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_SUBD
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form 1");
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (login.Text.Length != 0 || password.Text.Length != 0) {
                User user = new User(login.Text, password.Text, "employee");
                Connection.user = user;
                if (Connection.connect())
                {
                    Form dir = new employee();
                    dir.Show();
                    Console.WriteLine("Employee Connected");
                }
                else
                {
                    Connection.user = null;
                    Connection.error("Неправильное имя пользователя или пароль");
                }
            }
            else
            {
                Connection.error("Поля не могут быть пустыми");
            }
        }

    }
}
