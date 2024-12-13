namespace Snake_game
{
    partial class frmUsername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsername));
            btnPlay = new Button();
            btnClose = new Button();
            lblPresentation = new Label();
            txtUsername = new TextBox();
            btnRules = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(12, 108);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(12, 232);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblPresentation
            // 
            lblPresentation.AutoSize = true;
            lblPresentation.BackColor = Color.Transparent;
            lblPresentation.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPresentation.Location = new Point(2, 9);
            lblPresentation.Name = "lblPresentation";
            lblPresentation.Size = new Size(315, 22);
            lblPresentation.TabIndex = 2;
            lblPresentation.Text = "Hi, player, please enter your username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(118, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 3;
            // 
            // btnRules
            // 
            btnRules.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRules.Location = new Point(12, 165);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(75, 23);
            btnRules.TabIndex = 5;
            btnRules.Text = "Rules";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // frmUsername
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_08_at_9_04_51_AM;
            ClientSize = new Size(320, 278);
            Controls.Add(btnRules);
            Controls.Add(txtUsername);
            Controls.Add(lblPresentation);
            Controls.Add(btnClose);
            Controls.Add(btnPlay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsername";
            Text = "Username";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private Button btnClose;
        private Label lblPresentation;
        private TextBox txtUsername;
        private Button btnRules;
    }
}
