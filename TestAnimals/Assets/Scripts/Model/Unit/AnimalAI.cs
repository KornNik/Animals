using UnityEngine;

namespace TestAnimals.Model.Units
{
    class AnimalAI : ICatcheable
    {
        #region Fields

        private UnitBehaviour _unit;
        private AnimalStates _animalsStates;
        private Transform _leaderTransform;

        #endregion


        #region Properties

        public AnimalStates AnimalStates => _animalsStates;

        #endregion


        #region ClassLifeCycle

        public AnimalAI(UnitBehaviour unit)
        {
            _unit = unit;
            _animalsStates = AnimalStates.None;
        }

        #endregion


        #region ICatcheable

        public void SetLeader(Transform leaderTransform)
        {
            _leaderTransform = leaderTransform;
            _animalsStates = AnimalStates.Follow;
        }

        #endregion


        #region Methods

        public void AIUpdate()
        {
            if (AnimalStates == AnimalStates.Follow)
            {
                FollowTarget(_leaderTransform.position);
            }
        }

        private void FollowTarget(Vector3 targetPosition)
        {
            _unit.UnitMovement.Move(targetPosition.x,targetPosition.y);
        }

        #endregion
    }
}
