using UnityEngine;

namespace TestAnimals.Model.Units
{
    class SearchTargetOverlap
    {
        #region Fields

        private Collider2D[] _targets;
        private ICatcher _catcher;

        #endregion


        #region ClassLifeCycle

        public SearchTargetOverlap(ICatcher catcher)
        {
            _targets = new Collider2D[16];
            _catcher = catcher;
        }

        #endregion


        #region Methods

        public virtual void SearchTarget(Vector2 playerPosition, float distanceView, int layerMask)
        {
            var targetsCount = Physics2D.OverlapCircleNonAlloc(playerPosition, distanceView, _targets, layerMask);
            for (int i = 0; i < targetsCount; i++)
            {
                var victim = _targets[i].GetComponentInParent<CommonAnimal>();
                if (victim!=null)
                {
                    if (victim.AnimalAI.AnimalStates == AnimalStates.None)
                    {
                        _catcher.Catch(victim.AnimalAI);
                    }
                }
            }
        }
        public virtual void SearchTarget(Vector2 playerPosition, float distanceView, int layerMask, CommonDog player)
        {
            var targetsCount = Physics2D.OverlapCircleNonAlloc(playerPosition, distanceView, _targets, layerMask);
            for (int i = 0; i < targetsCount; i++)
            {
                var victim = _targets[i].GetComponentInParent<CommonAnimal>();
                if (victim != null)
                {
                    if (victim.AnimalAI.AnimalStates == AnimalStates.Follow)
                    {
                        player.AnimalsCatcher.AnimalsList.Remove(victim.AnimalAI);
                        _catcher.Catch(victim.AnimalAI);
                    }
                }
            }
        }
        public virtual bool IsTargetPresent(Vector2 playerPosition, float distanceView, int layerMask)
        {
            var isFindTarget = Physics2D.OverlapCircle(playerPosition, distanceView, layerMask);
            return isFindTarget;
        }

        #endregion
    }
}