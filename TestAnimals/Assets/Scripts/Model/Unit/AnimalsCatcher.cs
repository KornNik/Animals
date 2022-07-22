using System;
using UnityEngine;
using System.Collections;
using TestAnimals.Data.Units;
using System.Collections.Generic;

namespace TestAnimals.Model.Units
{
    class AnimalsCatcher : ICatcher
    {
        #region Fields

        private UnitBehaviour _unit;
        private UnitCatcherData _catcherData;
        private List<AnimalAI> _animalsList;
        private SearchTargetOverlap _targetOverlap;

        private int _animalsLayerMask = LayerMask.GetMask("Animal");

        #endregion


        #region Properties

        public List<AnimalAI> AnimalsList => _animalsList;

        #endregion


        #region ClassLifeCycle

        public AnimalsCatcher(UnitBehaviour unit, UnitCatcherData catcherData)
        {
            _unit = unit;
            _catcherData = catcherData;
            _animalsList = new List<AnimalAI>();
            _targetOverlap = new SearchTargetOverlap(this);
        }

        #endregion


        #region ICatcher

        public void Catch(ICatcheable animal)
        {
            animal.SetLeader(_unit.transform);
            _animalsList.Add(animal as AnimalAI);
        }

        #endregion


        #region Methods

        public void SearchAnimals()
        {
            if (_targetOverlap.IsTargetPresent(_unit.transform.position, _catcherData.CatchDistance, _animalsLayerMask))
            {
                _targetOverlap.SearchTarget(_unit.transform.position, _catcherData.CatchDistance, _animalsLayerMask);
            }
        }

        public void LeadAnimals()
        {
            if (_animalsList.Count > 0)
            {
                for (int i = 0; i < _animalsList.Count; i++)
                {
                    _animalsList[i].AIUpdate();
                }
            }
        }
        #endregion

    }
}