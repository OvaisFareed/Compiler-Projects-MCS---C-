namespace Lexical_Analyzer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.s_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear_btn = new System.Windows.Forms.Button();
            this.analyze_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type or Paste your Code here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Token sets:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 506);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_no,
            this.class_part,
            this.value_part,
            this.line_no});
            this.dataGridView1.Location = new System.Drawing.Point(439, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 506);
            this.dataGridView1.TabIndex = 3;
            // 
            // s_no
            // 
            this.s_no.HeaderText = "S No.";
            this.s_no.Name = "s_no";
            // 
            // class_part
            // 
            this.class_part.HeaderText = "Class Part";
            this.class_part.Name = "class_part";
            // 
            // value_part
            // 
            this.value_part.HeaderText = "Value Part";
            this.value_part.Name = "value_part";
            // 
            // line_no
            // 
            this.line_no.HeaderText = "Line No.";
            this.line_no.Name = "line_no";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 564);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(96, 32);
            this.clear_btn.TabIndex = 4;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // analyze_btn
            // 
            this.analyze_btn.Location = new System.Drawing.Point(322, 564);
            this.analyze_btn.Name = "analyze_btn";
            this.analyze_btn.Size = new System.Drawing.Size(95, 32);
            this.analyze_btn.TabIndex = 5;
            this.analyze_btn.Text = "Analyze";
            this.analyze_btn.UseVisualStyleBackColor = true;
            this.analyze_btn.Click += new System.EventHandler(this.analyze_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 564);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 642);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.analyze_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lexical Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_no;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button analyze_btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

