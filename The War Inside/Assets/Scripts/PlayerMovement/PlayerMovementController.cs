using System.Collections;
using System.Collections.Generic;
using TheWarInside.PlayerInput;

using UnityEngine;

namespace TheWarInside.PlayerMovement {
public class PlayerMovementController : MonoBehaviour
{

    #region Reference
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private InputData _inputData;
    [SerializeField] private PlayerMovementSettings _playerMovementSettings;
    #endregion
   

   
    void Update()
    {
        PlayerMoving();
    }



    #region  PlayerMove
    private void PlayerMoving()
    {
        _inputData.Horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(_inputData.Horizontal,0,0)*Time.deltaTime*_playerMovementSettings.HorizontalSpeed;
    }

    #endregion
}
}