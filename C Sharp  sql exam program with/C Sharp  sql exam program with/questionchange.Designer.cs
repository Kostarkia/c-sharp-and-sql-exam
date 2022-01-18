
namespace C_Sharp__sql_exam_program_with
{
    partial class questionchange
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 40);
            this.button4.TabIndex = 19;
            this.button4.Text = "Return";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(293, 411);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(158, 40);
            this.del.TabIndex = 18;
            this.del.Text = "Delete Question";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(806, 411);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(158, 40);
            this.list.TabIndex = 17;
            this.list.Text = "List Questions";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 294);
            this.dataGridView1.TabIndex = 16;
            // 
            // questionchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 467);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.del);
            this.Controls.Add(this.list);
            this.Controls.Add(this.dataGridView1);
            this.Name = "questionchange";
            this.Text = "questionchange";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}