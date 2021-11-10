using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gade6112
{
    public partial class Form1 : Form
    {

        GameEngine gameEngine;
        public int MinHeight;
        public int MaxHeight;
        public int MaxWidth;
        public int MinWidth;
        public int NumEnemies;


        int count;


        public Form1()
        {
            InitializeComponent();
            btn_Start.Visible = true;

        }

        private void btn_Start_Click(object sender, EventArgs e)    //starts the game once inputs are all there
        {
            gameEngine = new GameEngine(8, 12, 8, 12, 3);     //creates a game engine and gives it params to make the map

            DisplayMap();
            //lbl_GameScreen.Text = gameEngine.ToString();

            btn_Start.Visible = false;
        }
        public void DisplayMap() //main Display method
        {
            lbl_GameScreen.Text = "";  //erases it so it can be called with up to date values each time

            int rowLength = gameEngine.EngineMap.MapArray.GetLength(0);   //gets lengths of the array
            int colLength = gameEngine.EngineMap.MapArray.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    lbl_GameScreen.Text += string.Format("{0} ", gameEngine.EngineMap.MapArray[i, j].Symbol);        //prints out each tiles symbol element that is now a string array into a grid shape
                }
                lbl_GameScreen.Text += Environment.NewLine + Environment.NewLine;
            }

            lb_UpdateScreen.Items.Clear();   //clears the listbox every turn

            lbl_PlayerStats.Text = gameEngine.EngineMap.Hero.ToString();   //shows the player stats

            //anything to extra here
            gameEngine.EngineMap.UpdateVision();  //updates the vision everytime the map is reloaded
            checkSurroundings();

        }

        public void checkSurroundings()     //Displays the tiles in the heros vision array in the listbox
        {


            foreach (Tile tile in gameEngine.EngineMap.Hero.CharacterVision)  //searches all tiels in vision
            {

                lb_UpdateScreen.Items.Add(" " + tile.ToString());  //show it on the screen

            }
        }

        public void EnemyTurn()          //every "round" (after player input) the enemies will be moved and attack if necessary
        {
            for (int i = 0; i < gameEngine.EngineMap.EnemiesArray.GetLength(0); i++)
            {
                if (gameEngine.EngineMap.EnemiesArray[i] is Goblin)
                {
                    gameEngine.MoveEnemies(gameEngine.EngineMap.EnemiesArray[i].ReturnMovement(), i);  //goes to game engine to chenge their pos in the map array (will do return noMvm as mages dont move)
                    Goblin tempGoblin = (Goblin)gameEngine.EngineMap.EnemiesArray[i];
                    tempGoblin.AttackHero();
                }
                if (gameEngine.EngineMap.EnemiesArray[i] is Mage)
                {
                    gameEngine.MoveEnemies(gameEngine.EngineMap.EnemiesArray[i].ReturnMovement(), i);  //goes to game engine to chenge their pos in the map array (will do return noMvm as mages dont move)
                    Mage tempMage = (Mage)gameEngine.EngineMap.EnemiesArray[i]; //cast to mage in order to be able to attack
                    tempMage.AttackHero(); //attacks normal vision
                    tempMage.AttackDiagonal(); //attacks diagonal
                }
            }

            DisplayMap();  //after all moves and attacks it updates the map
        }


        //BUttons

        private void btn_Up_Click(object sender, EventArgs e)
        {

            gameEngine.MovePlayer(gameEngine.EngineMap.Hero.ReturnMovement(Character.movement.Up));     //movement is sent to hero ReturnMovement, it checks if valid, returns a movement and sent to the game engine MovePlayer which will move player and chenge its x and y pos
            rtb_HitAlert.Text = "";   //once moved it will reset the box that says if there was a hit
            DisplayMap();
            EnemyTurn();

        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(gameEngine.EngineMap.Hero.ReturnMovement(Character.movement.Right));
            rtb_HitAlert.Text = "";
            DisplayMap();
            EnemyTurn();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(gameEngine.EngineMap.Hero.ReturnMovement(Character.movement.Left));
            rtb_HitAlert.Text = "";
            DisplayMap();
            EnemyTurn();
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(gameEngine.EngineMap.Hero.ReturnMovement(Character.movement.Down));
            rtb_HitAlert.Text = "";
            DisplayMap();
            EnemyTurn();
        }

        private void btn_Attack_Click(object sender, EventArgs e)
        {
            if (lb_UpdateScreen.SelectedIndex == -1)   //if nothing is selected from the Listbox
            {
                lb_UpdateScreen.Items.Add("Please select an enemy to attack ^^");
            }
            else
            {
                rtb_HitAlert.Text = "Enemy Hit!";

                //attack logic
                //casts the tile in the vision array that the player will attack to a character so it can then be sent to Attack to do damage
                gameEngine.EngineMap.Hero.Attack((Character)gameEngine.EngineMap.MapArray[gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].X, gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].Y]);
                gameEngine.EngineMap.Hero.Attack((Character)gameEngine.EngineMap.MapArray[gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].X, gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].Y]);
                gameEngine.currentEnemy = (Character)gameEngine.EngineMap.MapArray[gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].X, gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].Y]; //saves the enemy to attack as a vairable

                if (gameEngine.currentEnemy.isDead())  //if the health of the attacked player gets to 0 or below it will replace the enemy with an empty tile
                {
                    gameEngine.EngineMap.MapArray[gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].X, gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].Y] = new EmptyTile(gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].X, gameEngine.EngineMap.Hero.CharacterVision[lb_UpdateScreen.SelectedIndex].Y, ".");
                }
                DisplayMap();
                
            }
            EnemyTurn();
        }

      
        private void btn_Save_Click(object sender, EventArgs e)
        {
            gameEngine.SaveGame(); // will run the save game method in game engine which will save to binary
            MessageBox.Show("Game Saved!");

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {  
            gameEngine.EngineMap = gameEngine.LoadGame(); //the current map being used will be set the one loaded from the file
            MessageBox.Show("Previous Save Loaded! Please click Ok");  //notif of completion
            DisplayMap();  //displays the loaded map
        }
    }
}
