using UnityEngine;

namespace TestAnimals.Data.Units
{
    [CreateAssetMenu(fileName ="UnitData",menuName ="Data/Unit/UnitData")]
    class UnitData : ScriptableObject
    {
        #region Fields

        [SerializeField] private UnitMovementData _movementData;
        [SerializeField] private UnitCatcherData _catcherData;

        #endregion


        #region Properties

        public UnitMovementData MovementData => _movementData;
        public UnitCatcherData UnitCatcherData => _catcherData;

        #endregion
    }
}
