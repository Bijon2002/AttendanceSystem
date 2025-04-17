namespace AttendanceSystem.project.forms
{
    partial class AdminForm
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
            label1 = new Label();
            btnLogout = new Button();
            btnExport = new Button();
            btnViewReport = new Button();
            btnRegister = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(426, 70);
            label1.Name = "label1";
            label1.Size = new Size(335, 48);
            label1.TabIndex = 0;
            label1.Text = " Admin Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Brown;
            btnLogout.Location = new Point(522, 461);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(165, 54);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExport
            // 
            btnExport.ForeColor = Color.Green;
            btnExport.Location = new Point(897, 317);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(210, 36);
            btnExport.TabIndex = 2;
            btnExport.Text = "View Students Details";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnViewReport
            // 
            btnViewReport.ForeColor = Color.Green;
            btnViewReport.Location = new Point(483, 298);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(264, 55);
            btnViewReport.TabIndex = 3;
            btnViewReport.Text = "View Attendance Report";
            btnViewReport.UseVisualStyleBackColor = true;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // btnRegister
            // 
            btnRegister.ForeColor = Color.Green;
            btnRegister.Location = new Point(232, 299);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(170, 54);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register Student";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images;
            pictureBox2.Location = new Point(103, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(299, 159);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._360_F_454518740_B6uk3YizdnnYogXw63dy0ndPTo4foLWt;
            pictureBox1.Location = new Point(448, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 159);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download;
            pictureBox3.Location = new Point(808, 194);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(299, 159);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 540);
            Controls.Add(btnRegister);
            Controls.Add(btnViewReport);
            Controls.Add(btnExport);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Button btnExport;
        private Button btnViewReport;
        private Button btnRegister;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}