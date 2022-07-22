using UnityEngine;
using TestAnimals.Model.Units;
using System.Collections.Generic;

namespace TestAnimals.Controller
{
    class AnimalsController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private List<CommonAnimal> _animalsList = new List<CommonAnimal>();

        #endregion


        #region UnityMethods

        private void Awake()
        {

        }

        private void FixedUpdate()
        {

        }

        #endregion
    }
}