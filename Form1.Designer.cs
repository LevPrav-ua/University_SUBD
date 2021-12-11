
namespace University_SUBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(143, 131);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(167, 34);
            this.login.TabIndex = 0;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_label.Location = new System.Drawing.Point(27, 131);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(93, 37);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Логин";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.director.Location = new System.Drawing.Point(88, 50);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(200, 46);
            this.director.TabIndex = 2;
            this.director.Text = "Сотрудник ";
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_text.Location = new System.Drawing.Point(27, 201);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(110, 37);
            this.password_text.TabIndex = 4;
            this.password_text.Text = "Пароль";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(143, 204);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 34);
            this.password.TabIndex = 3;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(128, 268);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(94, 29);
            this.send.TabIndex = 5;
            this.send.Text = "Войти";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 327);
            this.Controls.Add(this.send);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.password);
            this.Controls.Add(this.director);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        public System.Windows.Forms.Label login_label;
        public System.Windows.Forms.Label director;
        public System.Windows.Forms.Label password_text;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button send;
    }
}

