using UnityEngine;

namespace TestTask
{
    public class Plant : MonoBehaviour
    {
        [SerializeField] private PlantedCube _plantPrefab;
        [SerializeField] private Vector3 _plantOffset;

        private RaycastHit _hit;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.E))
                Instantiate(_plantPrefab, transform.position + _plantOffset, Quaternion.identity);

            if (Input.GetKeyUp(KeyCode.R))
            {
                if (Physics.Raycast(transform.position, transform.forward, out _hit) && _hit.transform.root.TryGetComponent(out PlantedCube cube))
                {
                    if (cube.IsRipe == true)
                        Destroy(cube.gameObject);
                }
            }
        }
    }
}
