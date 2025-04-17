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
using System.Net.Http;
using Newtonsoft.Json;


namespace AttendanceSystem.project.forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ReportForm_Load(object sender, EventArgs e)
        {
            string url = "http://localhost/ATTENDANCE_API/fetch_attendance.php";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var json = await client.GetStringAsync(url);
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load data: " + ex.Message);
                }
            }
        }


        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReportForm_Load(null, null); // Reload the dummy data
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
    {
                MessageBox.Show("No data to export!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "Attendance_Report.csv"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false))
                        {
                            // Headers
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                sw.Write(dataGridView1.Columns[i].HeaderText);
                                if (i < dataGridView1.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();

                            // Rows
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dataGridView1.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("Export successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Export failed: " + ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close report viewer
        }
    }
}
