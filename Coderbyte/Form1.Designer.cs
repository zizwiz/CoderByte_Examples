
namespace Coderbyte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rchtxtbx_output = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rchtxtbx_instructions = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_go = new System.Windows.Forms.Button();
            this.cmbobx_questions = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkbx_use_own_data = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_data = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 838);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rchtxtbx_output);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(645, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(520, 528);
            this.panel1.TabIndex = 0;
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_output.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.Size = new System.Drawing.Size(520, 528);
            this.rchtxtbx_output.TabIndex = 22;
            this.rchtxtbx_output.Text = "Output";
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.rchtxtbx_instructions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 298);
            this.panel2.TabIndex = 1;
            // 
            // rchtxtbx_instructions
            // 
            this.rchtxtbx_instructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_instructions.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbx_instructions.Name = "rchtxtbx_instructions";
            this.rchtxtbx_instructions.Size = new System.Drawing.Size(1162, 298);
            this.rchtxtbx_instructions.TabIndex = 41;
            this.rchtxtbx_instructions.Text = "Instructions";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_go);
            this.panel3.Controls.Add(this.cmbobx_questions);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 448);
            this.panel3.TabIndex = 2;
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(524, 66);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(85, 50);
            this.btn_go.TabIndex = 41;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // cmbobx_questions
            // 
            this.cmbobx_questions.FormattingEnabled = true;
            this.cmbobx_questions.Items.AddRange(new object[] {
            "Question Marks",
            "Fizz Buzz",
            "Two Sum Problem",
            "Remove Vowels",
            "Match Parenthesis",
            "Is it an Integer",
            "Kaprekars Constant",
            "Consecutive Numbers",
            "Number Encoding",
            "String Compression",
            "Prime Number",
            "Alphabet Sorter",
            "Change Letters",
            "Binary to Decimal",
            "StringToNumber 1",
            "StringToNumber 2",
            "Find Longest Word"});
            this.cmbobx_questions.Location = new System.Drawing.Point(28, 78);
            this.cmbobx_questions.Name = "cmbobx_questions";
            this.cmbobx_questions.Size = new System.Drawing.Size(471, 28);
            this.cmbobx_questions.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkbx_use_own_data);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtbx_data);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 74);
            this.panel4.TabIndex = 3;
            // 
            // chkbx_use_own_data
            // 
            this.chkbx_use_own_data.AutoSize = true;
            this.chkbx_use_own_data.Location = new System.Drawing.Point(492, 26);
            this.chkbx_use_own_data.Name = "chkbx_use_own_data";
            this.chkbx_use_own_data.Size = new System.Drawing.Size(133, 24);
            this.chkbx_use_own_data.TabIndex = 41;
            this.chkbx_use_own_data.Text = "Use own data";
            this.chkbx_use_own_data.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Test Data:";
            // 
            // txtbx_data
            // 
            this.txtbx_data.Location = new System.Drawing.Point(98, 23);
            this.txtbx_data.Name = "txtbx_data";
            this.txtbx_data.Size = new System.Drawing.Size(388, 26);
            this.txtbx_data.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 838);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Codebyte Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchtxtbx_output;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rchtxtbx_instructions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtbx_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbx_use_own_data;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.ComboBox cmbobx_questions;
    }
}

