using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

namespace My_First_VR
{
    public class ChangeMagnifyingGlassMaterial : MonoBehaviour
    {
        [SerializeField] private Material _clear;
        [SerializeField] private Material _mirror;

        public void SetMatClear()
        {
            GetComponent<Renderer>().material = _clear;
        }
        public void SetMatMirror()
        {
            GetComponent<Renderer>().material = _mirror;
        }
    }
}