using System;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        private float _strength;

        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider, int strength=2) : base(initPos, collider)
        {
            MaxHealth = 20;
            _strength = strength;
            Health = MaxHealth;
        }

        public void OnAttack(int amount)
        {
            AttackEvent((int)(amount * _strength));
        }

        public void AlterHealth(int amount)
        {
            Health += amount;
        }

        //increases MaxHealth and adds new amount Health
        public void buffHealth(int amount = 4) 
        {
            MaxHealth += amount;
            AlterHealth(amount);
        }

        //increases strength
        public void buffAttack(int amount = 2)
        {
            _strength += amount;
        }
    }
}
