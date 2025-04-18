namespace AttendanceSystem.project.forms
{
    partial class UserForm
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
            txtStudentID = new TextBox();
            dtDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cmbStatus = new ComboBox();
            btnSubmit = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 95);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(171, 89);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 31);
            txtStudentID.TabIndex = 1;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(171, 169);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(296, 31);
            dtDate.TabIndex = 4;
            dtDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 174);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 5;
            label2.Text = "Date";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 253);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 6;
            label3.Text = "\tStatus:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Present", "Absent" });
            cmbStatus.Location = new Point(171, 253);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 33);
            cmbStatus.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(209, 335);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.enter_details_2025;
            pictureBox1.Location = new Point(544, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 488);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1062, 438);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(237, 398);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 11;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 484);
            Controls.Add(lblStatus);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSubmit);
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtDate);
            Controls.Add(txtStudentID);
            Controls.Add(label1);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentID;
        private DateTimePicker dtDate;
        private Label label2;
        private Label label3;
        private ComboBox cmbStatus;
        private Button btnSubmit;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lblStatus;
    }
}