using UnityEngine;

namespace TestAnimals.Data.Units
{
    [CreateAssetMenu(fileName = "CatcherData",menuName ="Data/Unit/CatcherData")]
    class UnitCatcherData: ScriptableObject
    {
        #region Fields

        [SerializeField] private float _catchDistance;

        #endregion


        #region Properties

        public float CatchDistance => _catchDistance;

        #endregion
    }
}