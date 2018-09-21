using UnityEngine;

public class ResetCameraPosition : MonoBehaviour {
    [SerializeField]
    Transform _targetTransform;

    public void ResetPosition()
    {
        transform.position = new Vector3(_targetTransform.position.x, transform.position.y, _targetTransform.position.z);
    }
}
