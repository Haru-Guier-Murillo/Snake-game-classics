using Snake_game.Classes;
using Snake_game.Forms;


namespace Snake_game
{
    public partial class frmUsername : Form
    {
        public frmUsername()
        {
            InitializeComponent();
        }

        #region Metods
        public void Play()
        {
            string Username = txtUsername.Text;
            if (Username != string.Empty)
            {
                Game game = new Game();
                game.ShowDialog();
            }
            else if (Username == string.Empty)
            {
                var Complete = MessageBox.Show("Please write your username to play the game", "Warning");
                
            }
        }
        #endregion

        #region Events
        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Play();
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.ShowDialog();
        }
        #endregion



    }
}
