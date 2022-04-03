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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fakultet1DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.fakultet1DataSet.Student);

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagement stMan = new StudentManagement();
            stMan.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Visible = true;
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            StudentDataAccess studentData = new StudentDataAccess();
    
            if (textDelId.Text != null) {
                studentData.DeleteStudent(textDelId.Text);
                this.dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Niste unijeli valjani ID!");
            }    
            
     
        }

        
    }
}
