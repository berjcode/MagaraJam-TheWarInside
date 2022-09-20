using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheWarInside.Abstracts.Inputs{
    public class MobileInput : IPlayerInput
    {
        public float horizontal => Input.GetAxisRaw("Horizontal");
    }
}