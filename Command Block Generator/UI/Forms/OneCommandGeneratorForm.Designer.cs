using System.Windows.Forms;

namespace Command_Block_Generator.UI.Forms
{
    partial class OneCommandGeneratorForm
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

        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            label1 = new Label();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            checkBox3 = new CheckBox();
            label10 = new Label();
            textBox9 = new TextBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label12 = new Label();
            textBox11 = new TextBox();
            checkBox6 = new CheckBox();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            Input = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.MenuBar;
            checkBox1.Location = new Point(12, 272);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 22);
            checkBox1.TabIndex = 2;
            checkBox1.TabStop = false;
            checkBox1.Text = "Advanced";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 22);
            label1.TabIndex = 5;
            label1.Text = "One Command Generator";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = SystemColors.MenuBar;
            checkBox2.Location = new Point(12, 317);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(291, 22);
            checkBox2.TabIndex = 9;
            checkBox2.TabStop = false;
            checkBox2.Text = "Start next row where column ended";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 30, 30);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.MenuBar;
            textBox2.Location = new Point(77, 357);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(45, 18);
            textBox2.TabIndex = 2;
            textBox2.Text = "1";
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(30, 30, 30);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.MenuBar;
            textBox3.Location = new Point(77, 402);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(45, 18);
            textBox3.TabIndex = 3;
            textBox3.Text = "1";
            textBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(12, 402);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 14;
            label3.Text = "Height";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuBar;
            label4.Location = new Point(12, 357);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 15;
            label4.Text = "Width";
            label4.Visible = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(30, 30, 30);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.MenuBar;
            textBox4.Location = new Point(270, 357);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(112, 18);
            textBox4.TabIndex = 5;
            textBox4.Text = "X";
            textBox4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuBar;
            label5.Location = new Point(182, 357);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 17;
            label5.Text = "Increase";
            label5.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.MenuBar;
            label7.Location = new Point(12, 447);
            label7.Name = "label7";
            label7.Size = new Size(40, 18);
            label7.TabIndex = 20;
            label7.Text = "Skip";
            label7.Visible = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(30, 30, 30);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = SystemColors.MenuBar;
            textBox6.Location = new Point(77, 447);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(45, 18);
            textBox6.TabIndex = 4;
            textBox6.Text = "1";
            textBox6.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.MenuBar;
            label8.Location = new Point(432, 357);
            label8.Name = "label8";
            label8.Size = new Size(24, 18);
            label8.TabIndex = 26;
            label8.Text = "By";
            label8.Visible = false;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(30, 30, 30);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = SystemColors.MenuBar;
            textBox7.Location = new Point(462, 357);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(45, 18);
            textBox7.TabIndex = 8;
            textBox7.Text = "1";
            textBox7.Visible = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.ForeColor = SystemColors.MenuBar;
            checkBox3.Location = new Point(324, 317);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(243, 22);
            checkBox3.TabIndex = 30;
            checkBox3.TabStop = false;
            checkBox3.Text = "Rotate chain command blocks";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.MenuBar;
            label10.Location = new Point(573, 357);
            label10.Name = "label10";
            label10.Size = new Size(40, 18);
            label10.TabIndex = 31;
            label10.Text = "From";
            label10.Visible = false;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(30, 30, 30);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.ForeColor = SystemColors.MenuBar;
            textBox9.Location = new Point(619, 357);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(45, 18);
            textBox9.TabIndex = 10;
            textBox9.Text = "1";
            textBox9.Visible = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.ForeColor = SystemColors.MenuBar;
            checkBox4.Location = new Point(432, 445);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(43, 22);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "+X";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.Visible = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.ForeColor = SystemColors.MenuBar;
            checkBox5.Location = new Point(573, 443);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(43, 22);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "+Z";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.Visible = false;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.MenuBar;
            label12.Location = new Point(182, 446);
            label12.Name = "label12";
            label12.Size = new Size(56, 18);
            label12.TabIndex = 37;
            label12.Text = "Facing";
            label12.Visible = false;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(30, 30, 30);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.ForeColor = SystemColors.MenuBar;
            textBox11.Location = new Point(270, 447);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(112, 18);
            textBox11.TabIndex = 7;
            textBox11.Text = "east";
            textBox11.Visible = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.ForeColor = SystemColors.MenuBar;
            checkBox6.Location = new Point(573, 317);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(187, 22);
            checkBox6.TabIndex = 39;
            checkBox6.TabStop = false;
            checkBox6.Text = "Chain command blocks";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuBar;
            label6.Location = new Point(182, 402);
            label6.Name = "label6";
            label6.Size = new Size(72, 18);
            label6.TabIndex = 40;
            label6.Text = "Increase";
            label6.Visible = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(30, 30, 30);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.MenuBar;
            textBox5.Location = new Point(270, 402);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 18);
            textBox5.TabIndex = 6;
            textBox5.Text = "Y";
            textBox5.Visible = false;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(30, 30, 30);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.ForeColor = SystemColors.MenuBar;
            textBox8.Location = new Point(619, 402);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(45, 18);
            textBox8.TabIndex = 11;
            textBox8.Text = "1";
            textBox8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.MenuBar;
            label9.Location = new Point(573, 402);
            label9.Name = "label9";
            label9.Size = new Size(40, 18);
            label9.TabIndex = 44;
            label9.Text = "From";
            label9.Visible = false;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(30, 30, 30);
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.ForeColor = SystemColors.MenuBar;
            textBox10.Location = new Point(462, 402);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(45, 18);
            textBox10.TabIndex = 9;
            textBox10.Text = "1";
            textBox10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.MenuBar;
            label11.Location = new Point(432, 402);
            label11.Name = "label11";
            label11.Size = new Size(24, 18);
            label11.TabIndex = 42;
            label11.Text = "By";
            label11.Visible = false;
            // 
            // Input
            // 
            Input.BackColor = Color.FromArgb(30, 30, 30);
            Input.BorderStyle = BorderStyle.None;
            Input.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Input.ForeColor = SystemColors.ScrollBar;
            Input.Location = new Point(12, 96);
            Input.Name = "Input";
            Input.Size = new Size(936, 161);
            Input.TabIndex = 1;
            Input.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(180, 19);
            label2.TabIndex = 47;
            label2.Text = "Enter your commmand";
            // 
            // OneCommandGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(960, 495);
            Controls.Add(label2);
            Controls.Add(Input);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox10);
            Controls.Add(label11);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(checkBox6);
            Controls.Add(textBox11);
            Controls.Add(label12);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(checkBox3);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(checkBox2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "OneCommandGeneratorForm";
            Text = "Command Generator";
            Load += OneCommandGeneratorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox1;
        private Label label1;
        private CheckBox checkBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private CheckBox checkBox3;
        private Label label10;
        private TextBox textBox9;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label12;
        private TextBox textBox11;
        private CheckBox checkBox6;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox10;
        private Label label11;
        private RichTextBox Input;
        private Label label2;
    }
}