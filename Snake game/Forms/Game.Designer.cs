namespace Snake_game.Forms
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            tmrMove = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            SuspendLayout();
            // 
            // tmrMove
            // 
            tmrMove.Tick += tmrMove_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(508, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(64, 22);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score: ";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(584, 561);
            Controls.Add(lblScore);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game";
            Text = "frmGame";
            Paint += Game_Paint;
            KeyDown += Game_KeyDown_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private Label lblScore;
    }
}