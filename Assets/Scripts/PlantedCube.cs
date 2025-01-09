using UnityEngine;

namespace TestTask
{
    public class PlantedCube : MonoBehaviour
    {
        [SerializeField] private float _timeToRipe;
        [SerializeField] private float _ripeScaleMultiplier;
        [SerializeField] private Material _ripeMaterial;

        public bool IsRipe { get; private set; }

        private Renderer _renderer;

        private void Start()
        {
            _renderer = GetComponentInChildren<Renderer>();
        }

        private void Update()
        {
            if (_timeToRipe > 0)
                _timeToRipe -= Time.deltaTime;

            if (_timeToRipe <= 0 && IsRipe == false)
            {
                IsRipe = true;

                transform.localScale *= _ripeScaleMultiplier;
                _renderer.material = _ripeMaterial;
            }
        }
    }
}
