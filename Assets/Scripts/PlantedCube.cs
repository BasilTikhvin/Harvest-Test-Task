using System.Collections;
using UnityEngine;

namespace TestTask
{
    public class PlantedCube : MonoBehaviour
    {
        [SerializeField] private float _timeToGrow;
        [SerializeField] private float _grownScaleMultiplier;
        [SerializeField] private Material _grownMaterial;

        public bool IsGrown { get; private set; }

        private Renderer _renderer;

        private void Start()
        {
            _renderer = GetComponentInChildren<Renderer>();

            StartCoroutine(GrowingUp());
        }

        private IEnumerator GrowingUp()
        {
            yield return new WaitForSeconds(_timeToGrow);

            IsGrown = true;
            transform.localScale *= _grownScaleMultiplier;
            _renderer.material = _grownMaterial;
        }
    }
}
