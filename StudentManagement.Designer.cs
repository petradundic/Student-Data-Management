
namespace ITsistemi
{
    partial class StudentManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_new_student = new System.Windows.Forms.Button();
            this.Btn_st_list = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_unos = new System.Windows.Forms.Button();
            this.ime_label = new System.Windows.Forms.Label();
            this.prezime_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.godina_label = new System.Windows.Forms.Label();
            this.textIme = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textGod = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Studenti";
            // 
            // Btn_new_student
            // 
            this.Btn_new_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_new_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new_student.Location = new System.Drawing.Point(75, 100);
            this.Btn_new_student.Name = "Btn_new_student";
            this.Btn_new_student.Size = new System.Drawing.Size(179, 47);
            this.Btn_new_student.TabIndex = 1;
            this.Btn_new_student.Text = "Unos studenta";
            this.Btn_new_student.UseVisualStyleBackColor = false;
            this.Btn_new_student.Click += new System.EventHandler(this.Btn_new_student_Click);
            // 
            // Btn_st_list
            // 
            this.Btn_st_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_st_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_st_list.Location = new System.Drawing.Point(531, 90);
            this.Btn_st_list.Name = "Btn_st_list";
            this.Btn_st_list.Size = new System.Drawing.Size(182, 46);
            this.Btn_st_list.TabIndex = 2;
            this.Btn_st_list.Text = "Popis studenata";
            this.Btn_st_list.UseVisualStyleBackColor = false;
            this.Btn_st_list.Click += new System.EventHandler(this.Btn_st_list_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_unos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ime_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.prezime_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.status_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.godina_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textGod, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 213);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 226);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Visible = false;
            // 
            // Btn_unos
            // 
            this.Btn_unos.Location = new System.Drawing.Point(3, 187);
            this.Btn_unos.Name = "Btn_unos";
            this.Btn_unos.Size = new System.Drawing.Size(88, 30);
            this.Btn_unos.TabIndex = 4;
            this.Btn_unos.Text = "Unesi";
            this.Btn_unos.UseVisualStyleBackColor = true;
            this.Btn_unos.Click += new System.EventHandler(this.Btn_unos_Click);
            // 
            // ime_label
            // 
            this.ime_label.AutoSize = true;
            this.ime_label.Location = new System.Drawing.Point(3, 0);
            this.ime_label.Name = "ime_label";
            this.ime_label.Size = new System.Drawing.Size(34, 17);
            this.ime_label.TabIndex = 0;
            this.ime_label.Text = "Ime:";
            // 
            // prezime_label
            // 
            this.prezime_label.AutoSize = true;
            this.prezime_label.Location = new System.Drawing.Point(3, 46);
            this.prezime_label.Name = "prezime_label";
            this.prezime_label.Size = new System.Drawing.Size(63, 17);
            this.prezime_label.TabIndex = 1;
            this.prezime_label.Text = "Prezime:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(3, 92);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(52, 17);
            this.status_label.TabIndex = 2;
            this.status_label.Text = "Status:";
            // 
            // godina_label
            // 
            this.godina_label.AutoSize = true;
            this.godina_label.Location = new System.Drawing.Point(3, 138);
            this.godina_label.Name = "godina_label";
            this.godina_label.Size = new System.Drawing.Size(58, 17);
            this.godina_label.TabIndex = 3;
            this.godina_label.Text = "Godina:";
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(147, 3);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(100, 22);
            this.textIme.TabIndex = 4;
            // 
            // textPrezime
            // 
            this.textPrezime.Location = new System.Drawing.Point(147, 49);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(100, 22);
            this.textPrezime.TabIndex = 5;
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(147, 95);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(100, 22);
            this.textStatus.TabIndex = 6;
            // 
            // textGod
            // 
            this.textGod.Location = new System.Drawing.Point(147, 141);
            this.textGod.Name = "textGod";
            this.textGod.Size = new System.Drawing.Size(100, 22);
            this.textGod.TabIndex = 7;
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Btn_st_list);
            this.Controls.Add(this.Btn_new_student);
            this.Controls.Add(this.label1);
            this.Name = "StudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "unesi";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_new_student;
        private System.Windows.Forms.Button Btn_st_list;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ime_label;
        private System.Windows.Forms.Label prezime_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label godina_label;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textGod;
        private System.Windows.Forms.Button Btn_unos;

    }
}