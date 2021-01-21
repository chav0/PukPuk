﻿using Client.Model;
using UnityEngine;

namespace Client.ModelStates
{
    public class InitModelState : BaseModelState
    {
        public override ModelStatus Status => ModelStatus.Init;
        public override GameState GameState => null; 

        public override void Update()
        {

        }
    }
}
