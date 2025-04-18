using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data.SqlClient;


namespace AttendanceSystem.project.forms
{
    public partial class Viewall : Form
    {
        string connString = "Data Source=localhost;Initial Catalog=attendance_system;Integrated Security=True";
        public Viewall()
        {
            InitializeComponent();
        }

        private async void Viewall_Load(object sender, EventArgs e)
        {
            await LoadStudentData();
        }
        private async Task LoadStudentData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                await conn.OpenAsync();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM students", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a student row to delete.");
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

            var data = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("id", id)
    });

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync("http://localhost/attendance/delete_student.php", data);
                var result = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Deleted: " + result);
                await LoadStudentData(); // Refresh
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a student row first.");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            string id = row.Cells["id"].Value.ToString();
            string name = row.Cells["name"].Value.ToString();
            string course = row.Cells["course"].Value.ToString();

            var data = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("id", id),
        new KeyValuePair<string, string>("name", name),
        new KeyValuePair<string, string>("course", course)
    });

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync("http://localhost/attendance/update_student.php", data);
                var result = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Update: " + result);
                await LoadStudentData(); // Refresh after update
            }
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadStudentData();
        }
    }
}
