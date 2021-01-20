﻿using Client.Model;
using UnityEngine;

namespace Client.ModelStates
{
    public abstract class BaseModelState
    {
        public ClientModel Context; 
        public virtual World World { get; protected set; }
        public virtual ModelStatus Status { get; protected set; }
        
        
        public virtual void OnEnter()
        {
            
        }

        public virtual void OnExit()
        {
            
        }

        public abstract void Update();
        
        public void SetState(BaseModelState newState)
        {
            OnExit();
            newState.Context = Context;
            Context.CurrentState = newState;
            newState.OnEnter();
        }

        public virtual void AddGameInput(GameInput input)
        {

        }
    }
}
