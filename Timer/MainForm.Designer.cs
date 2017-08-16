namespace SBTMLite
{
    partial class SBTMLite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBTMLite));
            this.Counter = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.TesterInput = new System.Windows.Forms.TextBox();
            this.TesterLabel = new System.Windows.Forms.Label();
            this.AreaInput = new System.Windows.Forms.TextBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.CharterInput = new System.Windows.Forms.TextBox();
            this.CharterLabel = new System.Windows.Forms.Label();
            this.NotesInput = new System.Windows.Forms.RichTextBox();
            this.BugsInput = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.BugsLabel = new System.Windows.Forms.Label();
            this.ProjectInput = new System.Windows.Forms.TextBox();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.SBTMLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DevLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(152)))));
            this.Counter.Location = new System.Drawing.Point(80, 349);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(57, 13);
            this.Counter.TabIndex = 0;
            this.Counter.Text = "00:00:00";
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(67)))), ((int)(((byte)(134)))));
            this.Start.Location = new System.Drawing.Point(56, 324);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(50, 20);
            this.Start.TabIndex = 5;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Stop
            // 
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(67)))), ((int)(((byte)(134)))));
            this.Stop.Location = new System.Drawing.Point(112, 324);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(50, 20);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(67)))), ((int)(((byte)(134)))));
            this.Reset.Location = new System.Drawing.Point(53, 540);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(109, 20);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "RESET TOOL";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TesterInput
            // 
            this.TesterInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.TesterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TesterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.TesterInput.Location = new System.Drawing.Point(35, 82);
            this.TesterInput.Name = "TesterInput";
            this.TesterInput.Size = new System.Drawing.Size(154, 20);
            this.TesterInput.TabIndex = 1;
            this.TesterInput.TextChanged += new System.EventHandler(this.TesterInput_TextChanged);
            // 
            // TesterLabel
            // 
            this.TesterLabel.AutoSize = true;
            this.TesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(152)))));
            this.TesterLabel.Location = new System.Drawing.Point(32, 63);
            this.TesterLabel.Name = "TesterLabel";
            this.TesterLabel.Size = new System.Drawing.Size(53, 16);
            this.TesterLabel.TabIndex = 5;
            this.TesterLabel.Text = "Tester";
            // 
            // AreaInput
            // 
            this.AreaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.AreaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AreaInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.AreaInput.Location = new System.Drawing.Point(35, 188);
            this.AreaInput.Name = "AreaInput";
            this.AreaInput.Size = new System.Drawing.Size(154, 20);
            this.AreaInput.TabIndex = 3;
            this.AreaInput.TextChanged += new System.EventHandler(this.AreaInput_TextChanged);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(152)))));
            this.AreaLabel.Location = new System.Drawing.Point(32, 169);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(41, 16);
            this.AreaLabel.TabIndex = 7;
            this.AreaLabel.Text = "Area";
            // 
            // CharterInput
            // 
            this.CharterInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.CharterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharterInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.CharterInput.Location = new System.Drawing.Point(35, 239);
            this.CharterInput.Name = "CharterInput";
            this.CharterInput.Size = new System.Drawing.Size(154, 20);
            this.CharterInput.TabIndex = 4;
            this.CharterInput.TextChanged += new System.EventHandler(this.CharterInput_TextChanged);
            // 
            // CharterLabel
            // 
            this.CharterLabel.AutoSize = true;
            this.CharterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(152)))));
            this.CharterLabel.Location = new System.Drawing.Point(32, 220);
            this.CharterLabel.Name = "CharterLabel";
            this.CharterLabel.Size = new System.Drawing.Size(58, 16);
            this.CharterLabel.TabIndex = 9;
            this.CharterLabel.Text = "Charter";
            // 
            // NotesInput
            // 
            this.NotesInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.NotesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.NotesInput.Location = new System.Drawing.Point(234, 48);
            this.NotesInput.Name = "NotesInput";
            this.NotesInput.Size = new System.Drawing.Size(300, 211);
            this.NotesInput.TabIndex = 7;
            this.NotesInput.Tag = "";
            this.NotesInput.Text = "";
            this.NotesInput.TextChanged += new System.EventHandler(this.NotesInput_TextChanged);
            // 
            // BugsInput
            // 
            this.BugsInput.AcceptsTab = true;
            this.BugsInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BugsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.BugsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BugsInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.BugsInput.Location = new System.Drawing.Point(234, 324);
            this.BugsInput.Name = "BugsInput";
            this.BugsInput.Size = new System.Drawing.Size(300, 239);
            this.BugsInput.TabIndex = 8;
            this.BugsInput.Text = "";
            this.BugsInput.TextChanged += new System.EventHandler(this.BugsInput_TextChanged);
            // 
            // NotesLabel
            // 
            this.NotesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(152)))));
            this.NotesLabel.Location = new System.Drawing.Point(231, 29);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(60, 16);
            this.NotesLabel.TabIndex = 12;
            this.NotesLabel.Text = "NOTES";
            // 
            // BugsLabel
            // 
            this.BugsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BugsLabel.AutoSize = true;
            this.BugsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BugsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(152)))));
            this.BugsLabel.Location = new System.Drawing.Point(231, 305);
            this.BugsLabel.Name = "BugsLabel";
            this.BugsLabel.Size = new System.Drawing.Size(50, 16);
            this.BugsLabel.TabIndex = 13;
            this.BugsLabel.Text = "BUGS";
            // 
            // ProjectInput
            // 
            this.ProjectInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.ProjectInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.ProjectInput.Location = new System.Drawing.Point(35, 135);
            this.ProjectInput.Name = "ProjectInput";
            this.ProjectInput.Size = new System.Drawing.Size(154, 20);
            this.ProjectInput.TabIndex = 2;
            this.ProjectInput.TextChanged += new System.EventHandler(this.ProjectInput_TextChanged);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(152)))));
            this.ProjectLabel.Location = new System.Drawing.Point(32, 116);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(57, 16);
            this.ProjectLabel.TabIndex = 15;
            this.ProjectLabel.Text = "Project";
            // 
            // SBTMLabel
            // 
            this.SBTMLabel.AutoSize = true;
            this.SBTMLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBTMLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(67)))), ((int)(((byte)(134)))));
            this.SBTMLabel.Location = new System.Drawing.Point(30, 14);
            this.SBTMLabel.Name = "SBTMLabel";
            this.SBTMLabel.Size = new System.Drawing.Size(98, 34);
            this.SBTMLabel.TabIndex = 16;
            this.SBTMLabel.Text = "SBTM Lite";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(67)))), ((int)(((byte)(134)))));
            this.SaveButton.Location = new System.Drawing.Point(56, 498);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(47, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(67)))), ((int)(((byte)(134)))));
            this.LoadButton.Location = new System.Drawing.Point(109, 498);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(53, 23);
            this.LoadButton.TabIndex = 19;
            this.LoadButton.Text = "LOAD";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DevLabel
            // 
            this.DevLabel.AutoSize = true;
            this.DevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(67)))), ((int)(((byte)(134)))));
            this.DevLabel.Location = new System.Drawing.Point(128, -17);
            this.DevLabel.Name = "DevLabel";
            this.DevLabel.Size = new System.Drawing.Size(61, 9);
            this.DevLabel.TabIndex = 20;
            this.DevLabel.Text = "A Nethouse Tool";
            // 
            // SBTMLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(582, 639);
            this.Controls.Add(this.DevLabel);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SBTMLabel);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.ProjectInput);
            this.Controls.Add(this.BugsLabel);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.BugsInput);
            this.Controls.Add(this.NotesInput);
            this.Controls.Add(this.CharterLabel);
            this.Controls.Add(this.CharterInput);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.AreaInput);
            this.Controls.Add(this.TesterLabel);
            this.Controls.Add(this.TesterInput);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Counter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(598, 659);
            this.Name = "SBTMLite";
            this.Text = "SBTM Lite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox TesterInput;
        private System.Windows.Forms.Label TesterLabel;
        private System.Windows.Forms.TextBox AreaInput;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox CharterInput;
        private System.Windows.Forms.Label CharterLabel;
        private System.Windows.Forms.RichTextBox NotesInput;
        private System.Windows.Forms.RichTextBox BugsInput;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label BugsLabel;
        private System.Windows.Forms.TextBox ProjectInput;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label SBTMLabel;
        private System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Label Counter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label DevLabel;
    }
}

