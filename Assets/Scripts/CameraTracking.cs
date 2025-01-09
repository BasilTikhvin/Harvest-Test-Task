using UnityEngine;

namespace TestTask
{
    public class CameraTracking : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _cameraPositionOffset;

        private void Start()
        {
            transform.position = _target.position + _cameraPositionOffset;
        }

        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position, _target.position + _cameraPositionOffset, _moveSpeed * Time.deltaTime);
        }
    }
}
