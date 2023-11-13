namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public int Score { get; set; }

        public string playerName { get; set; }

        public Player(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            Score = 0;
        }
    }
}
