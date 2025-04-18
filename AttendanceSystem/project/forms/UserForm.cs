using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem.project.forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)

        {
            string studentID = txtStudentID.Text;
            string date = dtDate.Value.ToString("yyyy-MM-dd");
            string status = cmbStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(status))
            {
                lblStatus.Text = "Fill all fields!";
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                var data = new StringContent(
                    $"student_id={studentID}&date={date}&status={status}",
                    Encoding.UTF8,
                    "application/x-www-form-urlencoded"
                );

                try
                {
                    var response = await client.PostAsync("http://localhost/ATTENDANCE_API/submit_attendance.php", data);

                    if (response.IsSuccessStatusCode)
                        lblStatus.Text = "Attendance marked!";
                    else
                        lblStatus.Text = "Failed to submit!";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}
