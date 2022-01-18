
namespace C_Sharp__sql_exam_program_with
{
    partial class signin
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
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.asfaf = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(119, 164);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(100, 20);
            this.txtsurname.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Surname";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(119, 133);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 23;
            // 
            // asfaf
            // 
            this.asfaf.AutoSize = true;
            this.asfaf.Location = new System.Drawing.Point(33, 136);
            this.asfaf.Name = "asfaf";
            this.asfaf.Size = new System.Drawing.Size(35, 13);
            this.asfaf.TabIndex = 22;
            this.asfaf.Text = "Name";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(119, 190);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Age";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(36, 256);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(88, 41);
            this.signup.TabIndex = 18;
            this.signup.Text = "Register";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(119, 107);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 17;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(119, 81);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sign In";
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 323);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.asfaf);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signin";
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label asfaf;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}