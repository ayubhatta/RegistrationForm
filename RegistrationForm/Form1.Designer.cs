namespace RegistrationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtfname = new TextBox();
            txtUser = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtCtry = new TextBox();
            txtlname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Gender = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpDOB = new DateTimePicker();
            cmbGender = new ComboBox();
            label4 = new Label();
            txtPass = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtfname
            // 
            resources.ApplyResources(txtfname, "txtfname");
            txtfname.Name = "txtfname";
            // 
            // txtUser
            // 
            resources.ApplyResources(txtUser, "txtUser");
            txtUser.Name = "txtUser";
            // 
            // txtPhone
            // 
            resources.ApplyResources(txtPhone, "txtPhone");
            txtPhone.Name = "txtPhone";
            txtPhone.TextChanged += textBox3_TextChanged;
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // txtCtry
            // 
            resources.ApplyResources(txtCtry, "txtCtry");
            txtCtry.Name = "txtCtry";
            // 
            // txtlname
            // 
            resources.ApplyResources(txtlname, "txtlname");
            txtlname.Name = "txtlname";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // Gender
            // 
            resources.ApplyResources(Gender, "Gender");
            Gender.Name = "Gender";
            Gender.Click += Gender_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            label8.Click += label8_Click;
            // 
            // dtpDOB
            // 
            resources.ApplyResources(dtpDOB, "dtpDOB");
            dtpDOB.Name = "dtpDOB";
            // 
            // cmbGender
            // 
            cmbGender.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("cmbGender.AutoCompleteCustomSource"), resources.GetString("cmbGender.AutoCompleteCustomSource1"), resources.GetString("cmbGender.AutoCompleteCustomSource2") });
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { resources.GetString("cmbGender.Items"), resources.GetString("cmbGender.Items1"), resources.GetString("cmbGender.Items2") });
            resources.ApplyResources(cmbGender, "cmbGender");
            cmbGender.Name = "cmbGender";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // txtPass
            // 
            resources.ApplyResources(txtPass, "txtPass");
            txtPass.Name = "txtPass";
            txtPass.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(cmbGender);
            Controls.Add(dtpDOB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Gender);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtlname);
            Controls.Add(txtCtry);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtUser);
            Controls.Add(txtfname);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfname;
        private TextBox txtUser;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtCtry;
        private TextBox txtlname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Gender;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpDOB;
        private ComboBox cmbGender;
        private Label label4;
        private TextBox txtPass;
        private Button button2;
        private Button button1;
    }
}
