using System.Windows.Forms;
using LinkEngine.WorldGen;
using 

namespace UntitledRPG
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Player is the user's controllable object
        /// </summary>
        Adventurer Player;
        /// <summary>
        /// world is the object that gets populated with information about the game
        /// </summary>
        World world;

        public MainForm()
        {
            InitializeComponent();
        }

        Adventurer CreatePlayer ()
        {
            return null
        }
        World CreateWorld()
        {
            return null;
        }
        void SetupWorld ()
        {
            world = CreateWorld();
            Player = CreatePlayer();
        }

        #region Events
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Movement Keys
                case Keys.W:
                    // move up
                    Player.ShiftMap(0, 1);
                    break;
                case Keys.A:
                    // move left
                    Player.ShiftMap(-1, 0);
                    break;
                case Keys.S:
                    // move down
                    Player.ShiftMap(0, -1);
                    break;
                case Keys.D:
                    // move right
                    Player.ShiftMap(1, 0);
                    break;

                // Interaction Keys
                case Keys.Enter:
                    // interact
                    break;
            }
        }
        #endregion
    }
}
