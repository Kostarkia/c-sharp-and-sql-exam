
namespace C_Sharp__sql_exam_program_with
{
    partial class conclusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conclusion));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label3 = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.puan2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Age =";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblage.Location = new System.Drawing.Point(167, 118);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(18, 25);
            this.lblage.TabIndex = 21;
            this.lblage.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Surname =";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbls.Location = new System.Drawing.Point(167, 71);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(18, 25);
            this.lbls.TabIndex = 19;
            this.lbls.Text = ".";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb1.Location = new System.Drawing.Point(31, 23);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(86, 25);
            this.lb1.TabIndex = 13;
            this.lb1.Text = "Name =";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(368, 307);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(143, 56);
            this.button.TabIndex = 17;
            this.button.Text = "Yazdır";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username.Location = new System.Drawing.Point(167, 23);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(18, 25);
            this.username.TabIndex = 15;
            this.username.Text = ".";
            // 
            // puan2
            // 
            this.puan2.AutoSize = true;
            this.puan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan2.Location = new System.Drawing.Point(167, 171);
            this.puan2.Name = "puan2";
            this.puan2.Size = new System.Drawing.Size(18, 25);
            this.puan2.TabIndex = 16;
            this.puan2.Text = ".";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb3.Location = new System.Drawing.Point(31, 171);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(85, 25);
            this.lb3.TabIndex = 14;
            this.lb3.Text = "Point = ";
            // 
            // conclusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.username);
            this.Controls.Add(this.puan2);
            this.Controls.Add(this.lb3);
            this.Name = "conclusion";
            this.Text = "conclusion";
            this.Load += new System.EventHandler(this.conclusion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label puan2;
        private System.Windows.Forms.Label lb3;
    }
}