using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheWarInside.Abstracts.Movements;


namespace TheWarInside.Concreates.Movements{
    public class MoveRigidBody : IMove
    {
        Rigidbody2D rigidbody2D;
        float movementSpeed = 3;

    public MoveRigidBody(Rigidbody2D _rigidbody)
    {
        rigidbody2D = _rigidbody;
    }
       
        public void Movement(float horizontal)
        {
            Vector2 vec = new Vector2(horizontal*movementSpeed,rigidbody2D.velocity.y);
        }
    }
}