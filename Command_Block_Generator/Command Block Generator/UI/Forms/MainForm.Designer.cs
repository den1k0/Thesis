namespace Command_Block_Generator.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            generatorsToolStripMenuItem = new ToolStripMenuItem();
            oneCommandGeneratorToolStripMenuItem = new ToolStripMenuItem();
            potionGeneratorToolStripMenuItem = new ToolStripMenuItem();
            SubjectBox = new ToolStripComboBox();
            Panel = new Panel();
            label1 = new Label();
            CopyButton = new Button();
            GenerateButton = new Button();
            Output = new RichTextBox();
            RunButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { generatorsToolStripMenuItem, SubjectBox });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // generatorsToolStripMenuItem
            // 
            generatorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oneCommandGeneratorToolStripMenuItem, potionGeneratorToolStripMenuItem });
            generatorsToolStripMenuItem.Name = "generatorsToolStripMenuItem";
            generatorsToolStripMenuItem.Size = new Size(89, 29);
            generatorsToolStripMenuItem.Text = "Generators";
            // 
            // oneCommandGeneratorToolStripMenuItem
            // 
            oneCommandGeneratorToolStripMenuItem.Name = "oneCommandGeneratorToolStripMenuItem";
            oneCommandGeneratorToolStripMenuItem.Size = new Size(207, 22);
            oneCommandGeneratorToolStripMenuItem.Text = "OneCommandGenerator";
            oneCommandGeneratorToolStripMenuItem.Click += oneCommandGeneratorToolStripMenuItem_Click;
            // 
            // potionGeneratorToolStripMenuItem
            // 
            potionGeneratorToolStripMenuItem.Name = "potionGeneratorToolStripMenuItem";
            potionGeneratorToolStripMenuItem.Size = new Size(207, 22);
            potionGeneratorToolStripMenuItem.Text = "PotionGenerator";
            potionGeneratorToolStripMenuItem.Click += potionGeneratorToolStripMenuItem_Click;
            // 
            // SubjectBox
            // 
            SubjectBox.Alignment = ToolStripItemAlignment.Right;
            SubjectBox.BackColor = Color.FromArgb(30, 30, 30);
            SubjectBox.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SubjectBox.ForeColor = SystemColors.ScrollBar;
            SubjectBox.Items.AddRange(new object[] { "Player", "Server" });
            SubjectBox.Margin = new Padding(1, 0, 10, 0);
            SubjectBox.Name = "SubjectBox";
            SubjectBox.Padding = new Padding(3);
            SubjectBox.RightToLeft = RightToLeft.No;
            SubjectBox.Size = new Size(75, 29);
            SubjectBox.Text = "Player";
            // 
            // Panel
            // 
            Panel.BackColor = Color.FromArgb(20, 20, 20);
            Panel.Location = new Point(12, 38);
            Panel.Name = "Panel";
            Panel.Size = new Size(960, 495);
            Panel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(12, 540);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 3;
            label1.Text = "Output";
            // 
            // CopyButton
            // 
            CopyButton.FlatAppearance.BorderSize = 0;
            CopyButton.FlatStyle = FlatStyle.Flat;
            CopyButton.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CopyButton.ForeColor = SystemColors.ScrollBar;
            CopyButton.Image = (Image)resources.GetObject("CopyButton.Image");
            CopyButton.Location = new Point(900, 565);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(33, 33);
            CopyButton.TabIndex = 4;
            CopyButton.TabStop = false;
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // GenerateButton
            // 
            GenerateButton.FlatAppearance.BorderSize = 0;
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GenerateButton.ForeColor = SystemColors.ScrollBar;
            GenerateButton.Image = (Image)resources.GetObject("GenerateButton.Image");
            GenerateButton.Location = new Point(939, 564);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(33, 33);
            GenerateButton.TabIndex = 5;
            GenerateButton.TabStop = false;
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // Output
            // 
            Output.BackColor = Color.FromArgb(30, 30, 30);
            Output.BorderStyle = BorderStyle.None;
            Output.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Output.ForeColor = SystemColors.Window;
            Output.Location = new Point(12, 564);
            Output.Name = "Output";
            Output.ScrollBars = RichTextBoxScrollBars.Vertical;
            Output.Size = new Size(843, 80);
            Output.TabIndex = 30;
            Output.Text = "";
            // 
            // RunButton
            // 
            RunButton.BackColor = Color.FromArgb(20, 20, 20);
            RunButton.FlatAppearance.BorderSize = 0;
            RunButton.FlatStyle = FlatStyle.Flat;
            RunButton.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RunButton.ForeColor = SystemColors.ScrollBar;
            RunButton.Image = (Image)resources.GetObject("RunButton.Image");
            RunButton.Location = new Point(861, 564);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(36, 34);
            RunButton.TabIndex = 7;
            RunButton.TabStop = false;
            RunButton.UseMnemonic = false;
            RunButton.UseVisualStyleBackColor = false;
            RunButton.Click += RunButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(984, 656);
            Controls.Add(RunButton);
            Controls.Add(Output);
            Controls.Add(GenerateButton);
            Controls.Add(CopyButton);
            Controls.Add(label1);
            Controls.Add(Panel);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem generatorsToolStripMenuItem;
        private Panel Panel;
        private Label label1;
        private Button CopyButton;
        private Button GenerateButton;
        private ToolStripMenuItem oneCommandGeneratorToolStripMenuItem;
        private RichTextBox Output;
        private Button RunButton;
        private ToolStripComboBox SubjectBox;
        private ToolStripMenuItem potionGeneratorToolStripMenuItem;
    }
}