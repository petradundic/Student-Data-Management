using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace ITsistemi
{
    class StudentDataAccess
    {
        public List<Student> getAllStudents()
        {
            try
            {
                List<Student> listStudent = new List<Student>();
                using (SqlConnection connection = new SqlConnection(Helper.ConnectionVal("ITsistemi")))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM Student";
                        SqlDataReader dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            Student student = new Student();

                            student.studentId = (int)dataReader["studentId"];
                            student.ime = dataReader["ime"].ToString();
                            student.prezime = dataReader["prezime"].ToString();
                            student.status = dataReader["status"].ToString();
                            student.godina = (int)dataReader["godina"];

                            listStudent.Add(student);
                        }
                        dataReader.Close();
                    }
                    connection.Close();

                    return listStudent;
                }
            }
            catch
            {
                
                return null;
            }

           

        }
        public void AddNewStudent(Student newStudent)
        {
            var ime = newStudent.ime;
            var prezime = newStudent.prezime;
            var status = newStudent.status;
            var godina = newStudent.godina.ToString();

            SqlConnection sqlConnection1 = new SqlConnection(Helper.ConnectionVal("ITsistemi"));
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT Student (ime, prezime, status, godina ) VALUES ('"+ime+ "','" + prezime + "','" + status + "','" + godina + "')";
            cmd.Connection = sqlConnection1;
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            MessageBox.Show("Student uspjesno unesen!");


        }

        public void DeleteStudent(string id)
        {
            var listOfStudents = getAllStudents();
            StudentList stList = new StudentList();
            int Id = int.Parse(id);
            int count = 0;

            foreach(Student element in listOfStudents)
            {
                if (element.studentId == Id)
                    count = 1;
             
            }

            if(count != 0) { 
            SqlConnection sqlConnection1 = new SqlConnection(Helper.ConnectionVal("ITsistemi"));
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Delete Student WHERE studentId = @id", sqlConnection1);
            cmd.Parameters.AddWithValue("@id", int.Parse(id));
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            

                MessageBox.Show("Student uspjesno izbrisan!");
            }
            else
            {
                MessageBox.Show("Ne postoji trazeni student!");
            }

        }
    }
}
