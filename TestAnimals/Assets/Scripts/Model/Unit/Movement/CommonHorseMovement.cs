using UnityEngine;
using TestAnimals.Data.Units;

namespace TestAnimals.Model.Units
{
    class CommonHorseMovement : UnitMovement
    {
        #region Fields

        private Vector2 _directionMovement;

        #endregion


        #region ClassLifeCycle

        public CommonHorseMovement(UnitBehaviour unit, UnitMovementData movementData) : base(unit, movementData)
        {
            _unit = unit;
            _movementData = movementData;
        }

        #endregion


        #region IMove

        public override void Move(float horizontal, float vertical)
        {
            base.Move(horizontal, vertical);

            _movementPosition = new Vector2(horizontal, vertical);
            _directionMovement = _movementPosition - (Vector2)_unit.transform.position;

            _unit.transform.Translate(_directionMovement * _movementData.MovementSpeed * Time.fixedDeltaTime);
        }

        #endregion
    }
}
