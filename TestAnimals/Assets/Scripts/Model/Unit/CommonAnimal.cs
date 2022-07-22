using UnityEngine;

namespace TestAnimals.Model.Units
{
    class CommonAnimal : UnitBehaviour
    {
        #region Fields

        protected AnimalAI _animalAI;


        #endregion


        #region Properties

        public AnimalAI AnimalAI => _animalAI;

        #endregion


        #region UnityMethods

        protected override void Awake()
        {
            _unitMovement = new CommonHorseMovement(this,_unitData.MovementData);
            _animalAI = new AnimalAI(this);
        }

        #endregion


        #region Methods

        public void UpdateBehaviour()
        {
            _animalAI.AIUpdate();
        }

        #endregion
    }
}
