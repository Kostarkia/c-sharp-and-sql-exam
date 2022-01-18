
namespace C_Sharp__sql_exam_program_with
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.labellll = new System.Windows.Forms.Label();
            this.alogin = new System.Windows.Forms.Button();
            this.k4 = new System.Windows.Forms.TextBox();
            this.k3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.k2 = new System.Windows.Forms.TextBox();
            this.k1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(347, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Admin Login";
            // 
            // labellll
            // 
            this.labellll.AutoSize = true;
            this.labellll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labellll.Location = new System.Drawing.Point(102, 46);
            this.labellll.Name = "labellll";
            this.labellll.Size = new System.Drawing.Size(149, 25);
            this.labellll.TabIndex = 24;
            this.labellll.Text = "Member Login";
            // 
            // alogin
            // 
            this.alogin.Location = new System.Drawing.Point(332, 178);
            this.alogin.Name = "alogin";
            this.alogin.Size = new System.Drawing.Size(156, 23);
            this.alogin.TabIndex = 23;
            this.alogin.Text = "Login";
            this.alogin.UseVisualStyleBackColor = true;
            this.alogin.Click += new System.EventHandler(this.alogin_Click);
            // 
            // k4
            // 
            this.k4.Location = new System.Drawing.Point(388, 136);
            this.k4.Name = "k4";
            this.k4.Size = new System.Drawing.Size(100, 20);
            this.k4.TabIndex = 22;
            // 
            // k3
            // 
            this.k3.Location = new System.Drawing.Point(388, 93);
            this.k3.Name = "k3";
            this.k3.Size = new System.Drawing.Size(100, 20);
            this.k3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "User";
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(176, 178);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 23);
            this.signin.TabIndex = 18;
            this.signin.Text = "Sign in";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(86, 178);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 17;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // k2
            // 
            this.k2.Location = new System.Drawing.Point(151, 136);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(100, 20);
            this.k2.TabIndex = 16;
            // 
            // k1
            // 
            this.k1.Location = new System.Drawing.Point(151, 93);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(100, 20);
            this.k1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 270);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labellll);
            this.Controls.Add(this.alogin);
            this.Controls.Add(this.k4);
            this.Controls.Add(this.k3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.k1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labellll;
        private System.Windows.Forms.Button alogin;
        private System.Windows.Forms.TextBox k4;
        private System.Windows.Forms.TextBox k3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox k2;
        private System.Windows.Forms.TextBox k1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

