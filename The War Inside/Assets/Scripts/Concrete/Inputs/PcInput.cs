using System.Collections;
using System.Collections.Generic;
using TheWarInside.Abstracts.Inputs;
using UnityEngine;

namespace TheWarInside.Abstracts.Inputs{
    public class PcInput : IPlayerInput
    {
        
        public float horizontal => Input.GetAxisRaw("Horizontal");
    }
}