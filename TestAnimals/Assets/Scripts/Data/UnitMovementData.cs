using UnityEngine;

namespace TestAnimals.Data.Units
{
    [CreateAssetMenu(fileName = "UnitMovementData", menuName = "Data/Unit/UnitMovementData")]
    class UnitMovementData : ScriptableObject
    {
        #region Fields

        [SerializeField] private float _movementSpeed;

        #endregion


        #region Properties

        public float MovementSpeed => _movementSpeed;

        #endregion

    }
}
