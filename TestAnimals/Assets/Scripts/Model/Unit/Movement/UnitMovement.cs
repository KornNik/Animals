using UnityEngine;
using TestAnimals.Data.Units;

namespace TestAnimals.Model.Units
{
    abstract class UnitMovement : IMove
    {
        #region Fields

        protected UnitBehaviour _unit;
        protected UnitMovementData _movementData;

        protected Vector2 _movementPosition;

        #endregion


        #region ClassLifeCycle

        public UnitMovement(UnitBehaviour unit, UnitMovementData movementData)
        {
            _movementData = movementData;
            _unit = unit;
        }

        #endregion


        #region IMove

        public virtual void Move(float horizontal, float vertical)
        {

        }

        #endregion
    }
}
