using System;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// This is the class for an enemy
    /// </summary>
    public class Enemy : BattleCharacter
    {
        /// <summary>
        /// THis is the image for an enemy
        /// </summary>
        public Image Img { get; set; }

        /// <summary>
        /// this is the background color for the fight form for this enemy
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the enemy</param>
        /// <param name="collider">this is the collider for the enemy</param>
        public Enemy(Vector2 initPos, Collider collider, int strength=2) : base(initPos, collider, strength) { }

        // random movement function to make flea traverse map
        public void MoveRand()
        {
            Random rand = new Random();
            int moveDir = rand.Next(32);

            switch (moveDir)
            {
                case 0:
                    this.GoLeft();
                    //System.Diagnostics.Debug.WriteLine("W...");
                    break;
                case 1:
                    this.GoRight();
                    //System.Diagnostics.Debug.WriteLine("E...");
                    break;
                case 2:
                    this.GoUp();
                    //System.Diagnostics.Debug.WriteLine("N...");
                    break;
                case 3:
                    this.GoDown();
                    //System.Diagnostics.Debug.WriteLine("S...");
                    break;
                case 4:
                    this.GoNW();
                    //System.Diagnostics.Debug.WriteLine("NW...");
                    break;
                case 5:
                    this.GoNE();
                    //System.Diagnostics.Debug.WriteLine("NE...");
                    break;
                case 6:
                    this.GoSW();
                    //System.Diagnostics.Debug.WriteLine("SW...");
                    break;
                case 7:
                    this.GoSE();
                    //System.Diagnostics.Debug.WriteLine("SE...");
                    break;
                case 8:
                    this.ResetMoveSpeed();
                    //System.Diagnostics.Debug.WriteLine("stay...");
                    break;
                default:
                    break;
            }
        }
    }
}
