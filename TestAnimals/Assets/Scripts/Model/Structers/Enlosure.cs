using UnityEngine;
using System.Collections.Generic;
using TestAnimals.Model.Units;

namespace TestAnimals.Model.Structers
{
    class Enlosure : MonoBehaviour, ICatcher
    {
        #region Fields

        private HashSet<AnimalAI> _animalsList;
        private SearchTargetOverlap _targetOverlap;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _animalsList = new HashSet<AnimalAI>();
            _targetOverlap = new SearchTargetOverlap(this);
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            var player = collision.transform.GetComponentInParent<CommonDog>();
            if (player is CommonDog)
            {
                if (_targetOverlap.IsTargetPresent(transform.position, 2f, LayerMask.GetMask("Animal")))
                {
                    _targetOverlap.SearchTarget(transform.position, 2f, LayerMask.GetMask("Animal"), player);
                }
            }
        }
        #endregion


        #region ICatcher

        public void Catch(ICatcheable animal)
        {
            animal.SetLeader(transform);
            _animalsList.Add(animal as AnimalAI);
        }

        #endregion
    }
}
