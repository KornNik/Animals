namespace TestAnimals.Model.Units
{
    abstract class PlayerInput
    {

        #region Fields

        protected UnitBehaviour _unit;

        #endregion


        #region ClassLifeCycle

        public PlayerInput(UnitBehaviour unit)
        {
            _unit = unit;
        }

        #endregion


        #region Mehtods

        public abstract void InputsEntry();

        #endregion
    }
}