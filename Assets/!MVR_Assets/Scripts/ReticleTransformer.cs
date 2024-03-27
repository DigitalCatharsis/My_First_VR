using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace My_First_VR
{
    public class ReticleTransformer : MonoBehaviour
    {
        [SerializeField] private float _maxScale;
        [SerializeField] private float _minScale;
        [SerializeField] private float _scaleSpeed;
        [SerializeField] private float _rotationSpeed;

        private bool isScalingUp = true;

        // Start is called before the first frame update
        private void OnEnable()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
            // Scale the reticle up and down
            if (isScalingUp)
            {
                transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
                if (transform.localScale.x >= _maxScale)
                {
                    isScalingUp = false;
                }
            }
            else
            {
                transform.localScale -= Vector3.one * _scaleSpeed * Time.deltaTime;
                if (transform.localScale.x <= _minScale)
                {
                    isScalingUp = true;
                }
            }
        }
    }
}