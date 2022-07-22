using UnityEngine;
using TestAnimals.Model.Units;

namespace TestAnimals.Controller
{
    class PlayerController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private CommonDog[] _player;
        private int _index = 0;

        #endregion


        #region UnityMethods

        private void Awake()
        {

        }

        private void FixedUpdate()
        {
            _player[_index].PlayerInput.InputsEntry();
            _player[_index].AnimalsCatcher.SearchAnimals();
            _player[_index].AnimalsCatcher.LeadAnimals();

            if (Input.GetKey(KeyCode.Alpha1))
            {
                _index = 0;
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                _index = 1;
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                _index = 2;
            }
        }
        #endregion

    }
}
