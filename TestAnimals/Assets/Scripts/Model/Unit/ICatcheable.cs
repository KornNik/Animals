using UnityEngine;

namespace TestAnimals.Model.Units
{
    interface ICatcheable
    {
        AnimalStates AnimalStates { get; }
        void SetLeader(Transform leaderTransform);
    }
}