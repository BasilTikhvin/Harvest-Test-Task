using UnityEngine;

namespace TestTask
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;

        private Vector2 MovementDirection;

        private void Update()
        {
            PlayerInput();
            Move();
        }

        private void PlayerInput()
        {
            MovementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        
        private void Move()
        {
            transform.Translate(_moveSpeed * Time.deltaTime * MovementDirection.x, 0f, _moveSpeed * Time.deltaTime * MovementDirection.y);
        }
    }
}
