
namespace University_SUBD
{
    partial class Entrant
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
            this.exams = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.entrants = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.schedule = new System.Windows.Forms.Button();
            this.cathedras = new System.Windows.Forms.Button();
            this.stream = new System.Windows.Forms.Button();
            this.group_exams = new System.Windows.Forms.Button();
            this.group_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // exams
            // 
            this.exams.Location = new System.Drawing.Point(13, 170);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(117, 29);
            this.exams.TabIndex = 7;
            this.exams.Text = "Экзамены";
            this.exams.UseVisualStyleBackColor = true;
            this.exams.Click += new System.EventHandler(this.exams_Click);
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(15, 108);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(114, 29);
            this.faculty.TabIndex = 6;
            this.faculty.Text = "Факультеты";
            this.faculty.UseVisualStyleBackColor = true;
            this.faculty.Click += new System.EventHandler(this.faculty_Click);
            // 
            // entrants
            // 
            this.entrants.Location = new System.Drawing.Point(13, 53);
            this.entrants.Name = "entrants";
            this.entrants.Size = new System.Drawing.Size(117, 29);
            this.entrants.TabIndex = 5;
            this.entrants.Text = "Абитуриенты";
            this.entrants.UseVisualStyleBackColor = true;
            this.entrants.Click += new System.EventHandler(this.entrants_Click);
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(151, 26);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 29;
            this.Table.Size = new System.Drawing.Size(801, 368);
            this.Table.TabIndex = 4;
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(12, 225);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(117, 29);
            this.schedule.TabIndex = 8;
            this.schedule.Text = "Расписание";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // cathedras
            // 
            this.cathedras.Location = new System.Drawing.Point(12, 274);
            this.cathedras.Name = "cathedras";
            this.cathedras.Size = new System.Drawing.Size(114, 29);
            this.cathedras.TabIndex = 9;
            this.cathedras.Text = "Кафедры";
            this.cathedras.UseVisualStyleBackColor = true;
            this.cathedras.Click += new System.EventHandler(this.cathedras_Click);
            // 
            // stream
            // 
            this.stream.Location = new System.Drawing.Point(13, 327);
            this.stream.Name = "stream";
            this.stream.Size = new System.Drawing.Size(114, 29);
            this.stream.TabIndex = 10;
            this.stream.Text = "Поток";
            this.stream.UseVisualStyleBackColor = true;
            this.stream.Click += new System.EventHandler(this.stream_Click);
            // 
            // group_exams
            // 
            this.group_exams.Location = new System.Drawing.Point(836, 406);
            this.group_exams.Name = "group_exams";
            this.group_exams.Size = new System.Drawing.Size(116, 32);
            this.group_exams.TabIndex = 11;
            this.group_exams.Text = "Посмотреть";
            this.group_exams.UseVisualStyleBackColor = true;
            this.group_exams.Click += new System.EventHandler(this.group_exams_Click);
            // 
            // group_num
            // 
            this.group_num.Location = new System.Drawing.Point(686, 408);
            this.group_num.Name = "group_num";
            this.group_num.Size = new System.Drawing.Size(125, 27);
            this.group_num.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Экзамены для группы :";
            // 
            // Entrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group_num);
            this.Controls.Add(this.group_exams);
            this.Controls.Add(this.stream);
            this.Controls.Add(this.cathedras);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.exams);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.entrants);
            this.Controls.Add(this.Table);
            this.Name = "Entrant";
            this.Text = "Entrant";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exams;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Button entrants;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button cathedras;
        private System.Windows.Forms.Button stream;
        private System.Windows.Forms.Button group_exams;
        private System.Windows.Forms.TextBox group_num;
        private System.Windows.Forms.Label label1;
    }
}