using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Entity
{
    public class EStateMachine
    {
        private IEState currentState;

        public void ChangeState(IEState newState, EController controller)
        {
            currentState?.Exit(controller);
            currentState = newState;
            currentState?.Enter(controller);
        }

        public void UpdateState(EController controller)
        {
            currentState?.Update(controller);
        }
    }

}
