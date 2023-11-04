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
        /// THis is the name for an enemy
        /// </summary>
        public String Name { get; set; }

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
                    MoveVector(new Vector2(-1, 0)); //west
                    break;
                case 1:
                    MoveVector(new Vector2(+1, 0)); //east
                    break;
                case 2:
                    MoveVector(new Vector2(0, -1)); //north
                    break;
                case 3:
                    MoveVector(new Vector2(0, +1)); //south
                    break;
                case 4:
                    MoveVector(new Vector2(-1, -1)); //nw
                    break;
                case 5:
                    MoveVector(new Vector2(+1, -1)); //ne
                    break;
                case 6:
                    MoveVector(new Vector2(-1, +1)); //sw
                    break;
                case 7:
                    MoveVector(new Vector2(+1, +1)); //se
                    break;
                case 8:
                    this.ResetMoveSpeed();
                    break;
                default:
                    break;
            }
        }
    }
}
