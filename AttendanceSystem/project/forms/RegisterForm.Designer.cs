using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;




namespace AttendanceSystem.project.forms
{
    partial class RegisterForm
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
            label2 = new Label();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            txtCourse = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            lblStatus = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(628, 415);
            label1.Name = "label1";
            label1.Size = new Size(488, 60);
            label1.TabIndex = 0;
            label1.Text = " Register New Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 248);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "\tCourse:";
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(181, 175);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 31);
            txtStudentID.TabIndex = 3;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(181, 242);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(150, 31);
            txtCourse.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 94);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 5;
            label3.Text = "Full Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 178);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 6;
            label4.Text = "Student ID:";
            label4.Click += label4_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSeaGreen;
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(147, 324);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Online_School_Registration_System;
            pictureBox1.Location = new Point(425, -97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 588);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(167, 361);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkMagenta;
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(33, 427);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 484);
            Controls.Add(btnBack);
            Controls.Add(lblStatus);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCourse);
            Controls.Add(txtStudentID);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtStudentID;
        private TextBox txtCourse;
        private Label label3;
        private Label label4;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label lblStatus;
        private Button btnBack;
    }
}