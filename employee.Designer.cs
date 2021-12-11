
namespace University_SUBD
{
    partial class employee
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.entrant = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.exams = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(148, 12);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 29;
            this.Table.Size = new System.Drawing.Size(996, 368);
            this.Table.TabIndex = 0;
            // 
            // entrant
            // 
            this.entrant.Location = new System.Drawing.Point(10, 39);
            this.entrant.Name = "entrant";
            this.entrant.Size = new System.Drawing.Size(117, 29);
            this.entrant.TabIndex = 1;
            this.entrant.Text = "Абитуриенты";
            this.entrant.UseVisualStyleBackColor = true;
            this.entrant.Click += new System.EventHandler(this.entrant_Click);
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(12, 94);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(114, 29);
            this.faculty.TabIndex = 2;
            this.faculty.Text = "Факультеты";
            this.faculty.UseVisualStyleBackColor = true;
            // 
            // exams
            // 
            this.exams.Location = new System.Drawing.Point(10, 156);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(117, 29);
            this.exams.TabIndex = 3;
            this.exams.Text = "Экзамены";
            this.exams.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(10, 220);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(117, 29);
            this.report.TabIndex = 4;
            this.report.Text = "Отчёт";
            this.report.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(197, 406);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 29);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 458);
            this.Controls.Add(this.add);
            this.Controls.Add(this.report);
            this.Controls.Add(this.exams);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.entrant);
            this.Controls.Add(this.Table);
            this.Name = "employee";
            this.Text = "director";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button entrant;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Button exams;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button add;
    }
}