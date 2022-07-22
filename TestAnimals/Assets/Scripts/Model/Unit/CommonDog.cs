using UnityEngine;

namespace TestAnimals.Model.Units
{
    class CommonDog : UnitBehaviour
    {
        #region Fields

        protected PlayerInput _playerInput;
        protected AnimalsCatcher _animalsCatcher;

        #endregion


        #region Properties

        public AnimalsCatcher AnimalsCatcher => _animalsCatcher;
        public PlayerInput PlayerInput => _playerInput;

        #endregion


        #region UnityMethods

        protected override void Awake()
        {
            base.Awake();
            _playerInput = new TouchScreenInput(this);
            _animalsCatcher = new AnimalsCatcher(this, _unitData.UnitCatcherData);
            _unitMovement = new CommonDogMovement(this, _unitData.MovementData);
        }

        #endregion
    }
}
