namespace Command_Block_Generator.UI.Forms
{
    partial class PotionGeneratorForm
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
            PotionEffectBox = new ComboBox();
            AddToQueueButton = new Button();
            AmpbientSwitch = new CheckBox();
            ShowParticlesSwitch = new CheckBox();
            ShowIconSwitch = new CheckBox();
            DurationBox = new TextBox();
            AmplifierBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ClearButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            RedBox = new TextBox();
            BlueBox = new TextBox();
            GreenBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PotionTypeBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            PotionTree = new TreeView();
            label3 = new Label();
            UpdateButton = new Button();
            RemoveButton = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            PotionNameBox = new TextBox();
            SuspendLayout();
            // 
            // PotionEffectBox
            // 
            PotionEffectBox.BackColor = Color.FromArgb(30, 30, 30);
            PotionEffectBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PotionEffectBox.ForeColor = SystemColors.Window;
            PotionEffectBox.FormattingEnabled = true;
            PotionEffectBox.Items.AddRange(new object[] { "poison", "fire_resistance", "health_boost", "blindness", "speed", "slowness", "instant_damage", "instant_health", "strength", "jump_boost", "resistance", "regeneration" });
            PotionEffectBox.Location = new Point(308, 148);
            PotionEffectBox.Margin = new Padding(3, 2, 3, 2);
            PotionEffectBox.Name = "PotionEffectBox";
            PotionEffectBox.Size = new Size(197, 26);
            PotionEffectBox.TabIndex = 0;
            PotionEffectBox.TabStop = false;
            PotionEffectBox.Text = "health_boost";
            // 
            // AddToQueueButton
            // 
            AddToQueueButton.BackColor = Color.FromArgb(30, 30, 30);
            AddToQueueButton.FlatAppearance.BorderSize = 0;
            AddToQueueButton.FlatStyle = FlatStyle.Flat;
            AddToQueueButton.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddToQueueButton.ForeColor = SystemColors.Window;
            AddToQueueButton.Location = new Point(566, 447);
            AddToQueueButton.Margin = new Padding(3, 2, 3, 2);
            AddToQueueButton.Name = "AddToQueueButton";
            AddToQueueButton.Size = new Size(74, 24);
            AddToQueueButton.TabIndex = 1;
            AddToQueueButton.TabStop = false;
            AddToQueueButton.Text = "Add";
            AddToQueueButton.UseVisualStyleBackColor = false;
            AddToQueueButton.Click += AddToQueueButton_Click;
            // 
            // AmpbientSwitch
            // 
            AmpbientSwitch.AutoSize = true;
            AmpbientSwitch.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AmpbientSwitch.ForeColor = SystemColors.Window;
            AmpbientSwitch.Location = new Point(308, 315);
            AmpbientSwitch.Margin = new Padding(3, 2, 3, 2);
            AmpbientSwitch.Name = "AmpbientSwitch";
            AmpbientSwitch.Size = new Size(83, 22);
            AmpbientSwitch.TabIndex = 8;
            AmpbientSwitch.TabStop = false;
            AmpbientSwitch.Text = "Ambient";
            AmpbientSwitch.UseVisualStyleBackColor = true;
            // 
            // ShowParticlesSwitch
            // 
            ShowParticlesSwitch.AutoSize = true;
            ShowParticlesSwitch.Checked = true;
            ShowParticlesSwitch.CheckState = CheckState.Checked;
            ShowParticlesSwitch.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowParticlesSwitch.ForeColor = SystemColors.Window;
            ShowParticlesSwitch.Location = new Point(308, 263);
            ShowParticlesSwitch.Margin = new Padding(3, 2, 3, 2);
            ShowParticlesSwitch.Name = "ShowParticlesSwitch";
            ShowParticlesSwitch.Size = new Size(139, 22);
            ShowParticlesSwitch.TabIndex = 6;
            ShowParticlesSwitch.TabStop = false;
            ShowParticlesSwitch.Text = "Show Particles";
            ShowParticlesSwitch.UseVisualStyleBackColor = true;
            // 
            // ShowIconSwitch
            // 
            ShowIconSwitch.AutoSize = true;
            ShowIconSwitch.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowIconSwitch.ForeColor = SystemColors.Window;
            ShowIconSwitch.Location = new Point(308, 289);
            ShowIconSwitch.Margin = new Padding(3, 2, 3, 2);
            ShowIconSwitch.Name = "ShowIconSwitch";
            ShowIconSwitch.Size = new Size(99, 22);
            ShowIconSwitch.TabIndex = 7;
            ShowIconSwitch.TabStop = false;
            ShowIconSwitch.Text = "Show Icon";
            ShowIconSwitch.UseVisualStyleBackColor = true;
            // 
            // DurationBox
            // 
            DurationBox.BackColor = Color.FromArgb(30, 30, 30);
            DurationBox.BorderStyle = BorderStyle.None;
            DurationBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DurationBox.ForeColor = SystemColors.Window;
            DurationBox.Location = new Point(398, 200);
            DurationBox.Margin = new Padding(3, 2, 3, 2);
            DurationBox.Name = "DurationBox";
            DurationBox.Size = new Size(72, 18);
            DurationBox.TabIndex = 4;
            DurationBox.Text = "100";
            // 
            // AmplifierBox
            // 
            AmplifierBox.BackColor = Color.FromArgb(30, 30, 30);
            AmplifierBox.BorderStyle = BorderStyle.None;
            AmplifierBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AmplifierBox.ForeColor = SystemColors.Window;
            AmplifierBox.Location = new Point(398, 225);
            AmplifierBox.Margin = new Padding(3, 2, 3, 2);
            AmplifierBox.Name = "AmplifierBox";
            AmplifierBox.Size = new Size(72, 18);
            AmplifierBox.TabIndex = 5;
            AmplifierBox.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(308, 200);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 7;
            label1.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(308, 225);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 8;
            label2.Text = "Amplifier";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(30, 30, 30);
            ClearButton.FlatAppearance.BorderSize = 0;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.ForeColor = SystemColors.Window;
            ClearButton.Location = new Point(726, 447);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(80, 24);
            ClearButton.TabIndex = 12;
            ClearButton.TabStop = false;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // RedBox
            // 
            RedBox.BackColor = Color.FromArgb(30, 30, 30);
            RedBox.BorderStyle = BorderStyle.None;
            RedBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RedBox.ForeColor = SystemColors.Window;
            RedBox.Location = new Point(97, 299);
            RedBox.Margin = new Padding(3, 2, 3, 2);
            RedBox.Name = "RedBox";
            RedBox.Size = new Size(59, 18);
            RedBox.TabIndex = 1;
            RedBox.Text = "0";
            RedBox.TextChanged += RedBox_TextChanged;
            RedBox.Leave += RedBox_Leave;
            // 
            // BlueBox
            // 
            BlueBox.BackColor = Color.FromArgb(30, 30, 30);
            BlueBox.BorderStyle = BorderStyle.None;
            BlueBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BlueBox.ForeColor = SystemColors.Window;
            BlueBox.Location = new Point(97, 349);
            BlueBox.Margin = new Padding(3, 2, 3, 2);
            BlueBox.Name = "BlueBox";
            BlueBox.Size = new Size(59, 18);
            BlueBox.TabIndex = 3;
            BlueBox.Text = "0";
            BlueBox.TextChanged += BlueBox_TextChanged;
            BlueBox.Leave += BlueBox_Leave;
            // 
            // GreenBox
            // 
            GreenBox.BackColor = Color.FromArgb(30, 30, 30);
            GreenBox.BorderStyle = BorderStyle.None;
            GreenBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GreenBox.ForeColor = SystemColors.Window;
            GreenBox.Location = new Point(97, 324);
            GreenBox.Margin = new Padding(3, 2, 3, 2);
            GreenBox.Name = "GreenBox";
            GreenBox.Size = new Size(59, 18);
            GreenBox.TabIndex = 2;
            GreenBox.Text = "0";
            GreenBox.TextChanged += GreenBox_TextChanged;
            GreenBox.Leave += GreenBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(43, 299);
            label4.Name = "label4";
            label4.Size = new Size(32, 18);
            label4.TabIndex = 16;
            label4.Text = "Red";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(43, 324);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 17;
            label5.Text = "Green";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(43, 349);
            label6.Name = "label6";
            label6.Size = new Size(40, 18);
            label6.TabIndex = 18;
            label6.Text = "Blue";
            // 
            // PotionTypeBox
            // 
            PotionTypeBox.BackColor = Color.FromArgb(30, 30, 30);
            PotionTypeBox.FlatStyle = FlatStyle.System;
            PotionTypeBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PotionTypeBox.ForeColor = SystemColors.Window;
            PotionTypeBox.FormattingEnabled = true;
            PotionTypeBox.Items.AddRange(new object[] { "potion", "splash_potion", "lingering_potion", "tipped_arrow" });
            PotionTypeBox.Location = new Point(35, 148);
            PotionTypeBox.Margin = new Padding(3, 2, 3, 2);
            PotionTypeBox.Name = "PotionTypeBox";
            PotionTypeBox.Size = new Size(208, 26);
            PotionTypeBox.TabIndex = 19;
            PotionTypeBox.TabStop = false;
            PotionTypeBox.Text = "splash_potion";
            PotionTypeBox.SelectedIndexChanged += PotionTypeBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(12, 84);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 20;
            label7.Text = "Potion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(289, 84);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 21;
            label8.Text = "Effect:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.MenuBar;
            label9.Location = new Point(9, 9);
            label9.Name = "label9";
            label9.Size = new Size(170, 22);
            label9.TabIndex = 22;
            label9.Text = "Potion Generator";
            // 
            // PotionTree
            // 
            PotionTree.BackColor = Color.FromArgb(30, 30, 30);
            PotionTree.BorderStyle = BorderStyle.None;
            PotionTree.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PotionTree.ForeColor = SystemColors.Window;
            PotionTree.Location = new Point(566, 117);
            PotionTree.Name = "PotionTree";
            PotionTree.Size = new Size(320, 316);
            PotionTree.TabIndex = 23;
            PotionTree.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(545, 84);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 24;
            label3.Text = "View:";
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(30, 30, 30);
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.ForeColor = SystemColors.Window;
            UpdateButton.Location = new Point(812, 447);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(74, 24);
            UpdateButton.TabIndex = 25;
            UpdateButton.TabStop = false;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(30, 30, 30);
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.ForeColor = SystemColors.Window;
            RemoveButton.Location = new Point(646, 447);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(74, 24);
            RemoveButton.TabIndex = 26;
            RemoveButton.TabStop = false;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(35, 117);
            label10.Name = "label10";
            label10.Size = new Size(48, 18);
            label10.TabIndex = 27;
            label10.Text = "Type:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(35, 263);
            label11.Name = "label11";
            label11.Size = new Size(56, 18);
            label11.TabIndex = 28;
            label11.Text = "Color:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(313, 117);
            label12.Name = "label12";
            label12.Size = new Size(48, 18);
            label12.TabIndex = 29;
            label12.Text = "Name:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Window;
            label13.Location = new Point(35, 191);
            label13.Name = "label13";
            label13.Size = new Size(48, 18);
            label13.TabIndex = 30;
            label13.Text = "Name:";
            // 
            // PotionNameBox
            // 
            PotionNameBox.BackColor = Color.FromArgb(30, 30, 30);
            PotionNameBox.BorderStyle = BorderStyle.None;
            PotionNameBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PotionNameBox.ForeColor = SystemColors.Window;
            PotionNameBox.Location = new Point(35, 225);
            PotionNameBox.Margin = new Padding(3, 2, 3, 2);
            PotionNameBox.Name = "PotionNameBox";
            PotionNameBox.Size = new Size(208, 18);
            PotionNameBox.TabIndex = 31;
            PotionNameBox.Text = "Custom Potion";
            // 
            // PotionGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(960, 495);
            Controls.Add(PotionNameBox);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(RemoveButton);
            Controls.Add(UpdateButton);
            Controls.Add(label3);
            Controls.Add(PotionTree);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PotionTypeBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(GreenBox);
            Controls.Add(BlueBox);
            Controls.Add(RedBox);
            Controls.Add(ClearButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AmplifierBox);
            Controls.Add(DurationBox);
            Controls.Add(ShowIconSwitch);
            Controls.Add(ShowParticlesSwitch);
            Controls.Add(AmpbientSwitch);
            Controls.Add(AddToQueueButton);
            Controls.Add(PotionEffectBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PotionGeneratorForm";
            Text = "Form1";
            Load += PotionGeneratorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PotionEffectBox;
        private Button AddToQueueButton;
        private CheckBox AmpbientSwitch;
        private CheckBox ShowParticlesSwitch;
        private CheckBox ShowIconSwitch;
        private TextBox DurationBox;
        private TextBox AmplifierBox;
        private Label label1;
        private Label label2;
        private Button ClearButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox RedBox;
        private TextBox BlueBox;
        private TextBox GreenBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox PotionTypeBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private TreeView PotionTree;
        private Label label3;
        private Button UpdateButton;
        private Button RemoveButton;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox PotionNameBox;
    }
}