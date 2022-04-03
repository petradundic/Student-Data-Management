using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITsistemi
{
    public partial class StudentManagement : Form
    {
        

        public StudentManagement()
        {
            InitializeComponent();
        }

        

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            

        }

        private void Btn_new_student_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Visible = true;
        }

        private void Btn_unos_Click(object sender, EventArgs e)
        {
            Student addStudent = new Student();
            StudentDataAccess studentData = new StudentDataAccess();

            addStudent.ime = textIme.Text;
            addStudent.prezime = textPrezime.Text;
            addStudent.status = comboBox1.SelectedItem.ToString();
            addStudent.godina =int.Parse(textGod.Text);

            studentData.AddNewStudent(addStudent);
            textIme.Clear();
            textPrezime.Clear();
            textStatus.Clear();
            textGod.Clear();
        }

        private void Btn_st_list_Click(object sender, EventArgs e)
        {
            StudentList stList = new StudentList();
            stList.Show();
        }
    }
}
