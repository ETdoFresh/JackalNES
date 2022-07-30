using UnityEngine;

public class StaticRotation : MonoBehaviour
{
    private Quaternion _rotation;

    private void OnEnable()
    {
        _rotation = transform.rotation;
    }

    private void LateUpdate()
    {
        transform.rotation = _rotation;
    }
}
