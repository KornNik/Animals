using UnityEngine;
using TestAnimals.Data.Units;

namespace TestAnimals.Model.Units
{
    abstract class UnitBehaviour : MonoBehaviour
    {
        #region Fields

        [SerializeField] protected UnitData _unitData;
        [SerializeField] protected Collider2D _unitCollider;
        [SerializeField] protected UnitMovement _unitMovement;
        [SerializeField] protected Rigidbody2D _unitRigidbody;
 
        #endregion


        #region Properties

        public UnitData UnitData => _unitData;
        public Collider2D UnitCollider => _unitCollider;
        public Rigidbody2D UnitRigidbody => _unitRigidbody;
        public UnitMovement UnitMovement => _unitMovement;

        #endregion


        #region UnityMethods

        protected virtual void Awake()
        {
            _unitRigidbody.isKinematic = true;
        }

        #endregion

    }
}
