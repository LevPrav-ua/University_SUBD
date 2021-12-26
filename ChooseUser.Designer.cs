
namespace University_SUBD
{
    partial class ChooseUser
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
            this.entrant_btn = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entrant_btn
            // 
            this.entrant_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.entrant_btn.Location = new System.Drawing.Point(79, 135);
            this.entrant_btn.Name = "entrant_btn";
            this.entrant_btn.Size = new System.Drawing.Size(231, 121);
            this.entrant_btn.TabIndex = 0;
            this.entrant_btn.Text = "Абитуриент";
            this.entrant_btn.UseVisualStyleBackColor = true;
            this.entrant_btn.Click += new System.EventHandler(this.entrant_btn_Click);
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employee.Location = new System.Drawing.Point(79, 295);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(231, 133);
            this.employee.TabIndex = 1;
            this.employee.Text = "Сотрудник приёмной комиссии";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Войти как";
            // 
            // ChooseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.entrant_btn);
            this.Name = "ChooseUser";
            this.Text = "ChooseUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrant_btn;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Label label1;
    }
}