using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace TDShooter.Input
{
    public class PlayerControl : MonoBehaviour
    {
        private Controls _controls;
        [SerializeField]
        private float _speed;
        //private Vector2 _direction;
        private void Awake()
        {
            _controls = new Controls();
        }
        private void OnEnable()
        {
            _controls.Player.Enable();
            _controls.Player.Shoot.performed += context => Fire();
            //_controls.Player.WASD.performed += callbackContext => SetMotion(callbackContext.ReadValue<Vector2>());
        }

        /*private void SetMotion(Vector2 vector2)
        {
            _direction += vector2;
        }*/

        private void Move()
        {
            var inputValio = _controls.Player.WASD.ReadValue<Vector2>(); 
            transform.Translate(inputValio.x * Time.deltaTime * _speed, 0, inputValio.y * Time.deltaTime * _speed);
            //transform.Translate(Time.deltaTime * _speed * new Vector3(_direction.x, 0, _direction.y));
        }

        private void Update()
        {
            Move();
        }

        private void Fire()
        {
            Debug.Log("Делаем выстрел");
        }

        private void OnDisable()
        {            
            _controls.Player.Disable();
        }
    }
}