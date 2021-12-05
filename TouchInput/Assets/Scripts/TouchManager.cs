using Niantic.ARDK.Utilities;
using UnityEngine;

namespace TouchInput
{
    public class TouchManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _obj;

        private void Start()
        {
            _obj.SetActive(false);
        }

        private void Update()
        {
            if (PlatformAgnosticInput.touchCount <= 0)
            {
                return;
            }

            var touch = PlatformAgnosticInput.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                _obj.SetActive(true);
                _obj.transform.position = touch.position;
            }
        }
    }
}