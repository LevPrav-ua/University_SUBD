
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
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.current_line_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reference = new System.Windows.Forms.Button();
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
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
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
            this.faculty.Click += new System.EventHandler(this.faculty_Click);
            // 
            // exams
            // 
            this.exams.Location = new System.Drawing.Point(10, 156);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(117, 29);
            this.exams.TabIndex = 3;
            this.exams.Text = "Экзамены";
            this.exams.UseVisualStyleBackColor = true;
            this.exams.Click += new System.EventHandler(this.exams_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(9, 406);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(117, 29);
            this.report.TabIndex = 4;
            this.report.Text = "Отчёт";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
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
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(373, 406);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 29);
            this.delete.TabIndex = 6;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Enabled = false;
            this.update.Location = new System.Drawing.Point(558, 406);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 29);
            this.update.TabIndex = 7;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // current_line_text
            // 
            this.current_line_text.Location = new System.Drawing.Point(974, 407);
            this.current_line_text.Name = "current_line_text";
            this.current_line_text.Size = new System.Drawing.Size(125, 27);
            this.current_line_text.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(810, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Текущая строка:";
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(12, 351);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(114, 29);
            this.reference.TabIndex = 10;
            this.reference.Text = "Справка";
            this.reference.UseVisualStyleBackColor = true;
            this.reference.Click += new System.EventHandler(this.reference_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 458);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.current_line_text);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button entrant;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Button exams;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox current_line_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reference;
    }
}