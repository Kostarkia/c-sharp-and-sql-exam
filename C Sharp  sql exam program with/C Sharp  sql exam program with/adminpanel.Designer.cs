
namespace C_Sharp__sql_exam_program_with
{
    partial class adminpanel
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
            this.mt = new System.Windows.Forms.Button();
            this.qp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mt
            // 
            this.mt.Location = new System.Drawing.Point(21, 39);
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(192, 126);
            this.mt.TabIndex = 0;
            this.mt.Text = "Member Transactions";
            this.mt.UseVisualStyleBackColor = true;
            this.mt.Click += new System.EventHandler(this.mt_Click);
            // 
            // qp
            // 
            this.qp.Location = new System.Drawing.Point(282, 39);
            this.qp.Name = "qp";
            this.qp.Size = new System.Drawing.Size(192, 126);
            this.qp.TabIndex = 1;
            this.qp.Text = "Question Procedures";
            this.qp.UseVisualStyleBackColor = true;
            this.qp.Click += new System.EventHandler(this.qp_Click);
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 201);
            this.Controls.Add(this.qp);
            this.Controls.Add(this.mt);
            this.Name = "adminpanel";
            this.Text = "adminpanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mt;
        private System.Windows.Forms.Button qp;
    }
}