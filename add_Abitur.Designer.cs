
namespace University_SUBD
{
    partial class add_Abitur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.surname = new System.Windows.Forms.TextBox();
            this.second_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.ComboBox();
            this.cathedra = new System.Windows.Forms.ComboBox();
            this.group = new System.Windows.Forms.ComboBox();
            this.send = new System.Windows.Forms.Button();
            this.passport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(138, 57);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(250, 27);
            this.surname.TabIndex = 0;
            // 
            // second_name
            // 
            this.second_name.Location = new System.Drawing.Point(138, 154);
            this.second_name.Name = "second_name";
            this.second_name.Size = new System.Drawing.Size(250, 27);
            this.second_name.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(138, 108);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(250, 27);
            this.name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Факультет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Кафедра";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Группа";
            // 
            // faculty
            // 
            this.faculty.FormattingEnabled = true;
            this.faculty.Location = new System.Drawing.Point(518, 57);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(225, 28);
            this.faculty.TabIndex = 14;
            this.faculty.SelectedIndexChanged += new System.EventHandler(this.faculty_SelectedIndexChanged);
            // 
            // cathedra
            // 
            this.cathedra.FormattingEnabled = true;
            this.cathedra.Location = new System.Drawing.Point(518, 108);
            this.cathedra.Name = "cathedra";
            this.cathedra.Size = new System.Drawing.Size(225, 28);
            this.cathedra.TabIndex = 15;
            this.cathedra.SelectedIndexChanged += new System.EventHandler(this.cathedra_SelectedIndexChanged);
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Location = new System.Drawing.Point(518, 151);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(225, 28);
            this.group.TabIndex = 16;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(414, 270);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(149, 51);
            this.send.TabIndex = 17;
            this.send.Text = "ДОБАВИТЬ";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // passport
            // 
            this.passport.Location = new System.Drawing.Point(138, 201);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(250, 27);
            this.passport.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Паспорт";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(597, 270);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(121, 51);
            this.close.TabIndex = 20;
            this.close.Text = "ЗАКРЫТЬ";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // add_Abitur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 342);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.send);
            this.Controls.Add(this.group);
            this.Controls.Add(this.cathedra);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.second_name);
            this.Controls.Add(this.surname);
            this.Name = "add_Abitur";
            this.Text = "add_Abitur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox second_name;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox faculty;
        private System.Windows.Forms.ComboBox cathedra;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox passport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button close;
    }
}