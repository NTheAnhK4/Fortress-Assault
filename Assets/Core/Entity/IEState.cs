using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Entity
{
    public interface IEState
    {
        void Enter(EController controller);
        void Update(EController controller);
        void Exit(EController controller);
    }

}
