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
                    //System.Diagnostics.Debug.WriteLine("left...");
                    break;
                case 1:
                    this.GoUp();
                    //System.Diagnostics.Debug.WriteLine("up...");
                    break;
                case 2:
                    this.GoRight();
                    //System.Diagnostics.Debug.WriteLine("right...");
                    break;
                case 3:
                    this.GoDown();
                    //System.Diagnostics.Debug.WriteLine("down...");
                    break;
                case 4:
                    this.ResetMoveSpeed();
                    //System.Diagnostics.Debug.WriteLine("stay...");
                    break;
                default:
                    break;
            }
        }
    }
}
