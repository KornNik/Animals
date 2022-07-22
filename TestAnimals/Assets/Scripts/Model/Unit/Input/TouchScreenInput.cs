using UnityEngine;

namespace TestAnimals.Model.Units
{
    class TouchScreenInput : PlayerInput
    {
        #region Fields

        private Camera _camera;
        private Touch[] _touches;
        private RaycastHit2D _hit2D;

        #endregion


        #region ClassLifeCycle

        public TouchScreenInput(UnitBehaviour unit) : base(unit)
        {
            _unit = unit;
            _camera = Camera.main;
        }

        #endregion


        #region Methods

        public override void InputsEntry()
        {
            if (Input.touchCount > 0)
            {
                _touches = Input.touches;
                var ray = _camera.ScreenPointToRay(_touches[0].position);
                _hit2D = Physics2D.Raycast(ray.origin, ray.direction, 20f, LayerMask.GetMask("Ground"));
                if (_hit2D.point != null)
                {
                    MoveToTap(_hit2D.point);
                }
            }
            if (Input.GetMouseButton(0))
            {
                var ray = _camera.ScreenPointToRay(Input.mousePosition);
                _hit2D = Physics2D.Raycast(ray.origin, ray.direction, 20f, LayerMask.GetMask("Ground"));
                if (_hit2D.point != null)
                {
                    MoveToTap(_hit2D.point);
                }
            }
        }

        private void MoveToTap(Vector2 position)
        {
            _unit.UnitMovement.Move(position.x, position.y);
        }
        #endregion
    }
}