﻿namespace Fall2020_CSC403_Project.code
{
    public class Character
    {
        private const int GO_INC = 3;

        public Vector2 MoveSpeed { get; private set; }
        public Vector2 LastPosition { get; private set; }
        public Vector2 Position { get; private set; }
        public Collider Collider { get; private set; }

        public Character(Vector2 initPos, Collider collider)
        {
            Position = initPos;
            Collider = collider;
        }

        public void Move()
        {
            LastPosition = Position;
            Position = new Vector2(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
            Collider.MovePosition((int)Position.x, (int)Position.y);
        }

        public void Teleport(Vector2 vector)
        {
            Position = vector;
            Collider.MovePosition((int)Position.x, (int)Position.y);
        }

        public void MoveBack()
        {
            Position = LastPosition;
        }

        public void MoveVector(Vector2 vector) 
        {
            MoveSpeed = new Vector2(GO_INC * vector.x, GO_INC * vector.y);
        }

        public void ResetMoveSpeed()
        {
            MoveSpeed = new Vector2(0, 0);
        }
    }
}
