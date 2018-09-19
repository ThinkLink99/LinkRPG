using System.Windows.Forms;
using LinkEngine.WorldGen;
using LinkEngine.Entities;

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
            Adventurer player = new Adventurer(0, "Adventurer", new Class("Rogue", "", 4, 7, 4, 5, 4, 5, 3, 50, 10), 1, 0, 100, 10, "player");
            return player;
        }
        void GenerateWorld ()
        {
            DungeonGeneration generation = new DungeonGeneration();
            generation.BuildMap(1, world.Biomes[0], 1, 1);
        }
        World CreateWorld()
        {
            World _world = new World();
            _world.Player = Player;

            try { _world.LoadEnemyDatabase(""); } catch { }
            try { _world.LoadTileDatabase(""); } catch { }
            try { _world.LoadBiomeDatabase(""); } catch { }

            return _world;
        }
        void SetupWorld ()
        {
            Player = CreatePlayer();

            world = CreateWorld();

            GenerateWorld();
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
        private void DrawTimer_Tick(object sender, System.EventArgs e)
        {
            // Draw Things to the screen
        }
        #endregion
    }
}
