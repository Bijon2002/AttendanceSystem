using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem.project.forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)

        {
            string name = txtName.Text;
            string studentId = txtStudentID.Text;
            string course = txtCourse.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(course))
            {
                lblStatus.Text = "❌ Please fill all fields.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            var client = new HttpClient();
            var url = "http://localhost/attendance_api/register_student.php";

            var student = new
            {
                name = name,
                student_id = studentId,
                course = course
            };

            var json = JsonSerializer.Serialize(student);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();

                if (result.Contains("ok"))
                {
                    lblStatus.Text = "✅ Registered successfully!";
                    lblStatus.ForeColor = Color.Green;
                    txtName.Clear();
                    txtStudentID.Clear();
                    txtCourse.Clear();
                }
                else
                {
                    lblStatus.Text = "❌ Registration failed!";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Error: " + ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close report viewer
        }
    }
}
