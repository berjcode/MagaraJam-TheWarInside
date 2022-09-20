using System.Collections;
using System.Collections.Generic;
using TheWarInside.Abstracts.Inputs;
using UnityEngine;
using  TheWarInside.Abstracts.Movements;
using TheWarInside.Concreates.Movements;


namespace TheWarInside.Controllers{
public class PlayerManager : MonoBehaviour
{
    IPlayerInput  _input;
    IMove _move;
    void Start()
    {
        _input = new PcInput();
        _move = new  MoveRigidBody(GetComponent<Rigidbody2D>());
    }

    void FixedUpdate()
    {
        _move.Movement(_input.horizontal);
    }
    
}
}
