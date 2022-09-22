using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TheWarInside.PlayerCamera{
public class CameraController : MonoBehaviour
{
    #region  Referance
    [SerializeField] private CameraSettings _cameraSettings;
    #endregion

    #region Variables
    public Transform target;
    #endregion

void Update()
{
    transform.position = Vector3.Slerp(transform.position,new Vector3(target.position.x,target.position.y,transform.position.z),_cameraSettings.cameraSpeed);
}
    
}
}

