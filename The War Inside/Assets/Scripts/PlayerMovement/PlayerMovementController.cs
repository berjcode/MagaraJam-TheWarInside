using System.Collections;
using System.Collections.Generic;
using TheWarInside.PlayerInput;
using UnityEngine;


namespace TheWarInside.PlayerMovement{
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private InputData _inputData;

    [SerializeField] private PlayerMovementSettings _playerMovementSettings;


    void Update()
    {
        
    }
}

}