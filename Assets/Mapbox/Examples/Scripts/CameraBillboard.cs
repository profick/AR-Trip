namespace Mapbox.Examples
{
	using UnityEngine;

	public class CameraBillboard : MonoBehaviour
	{
		public Camera _camera;

		public void Start()
		{
			_camera = Camera.main;
		}

		void Update()
		{
		    Vector3 _vector = _camera.transform.position - transform.position;
		    _vector.x = _vector.z = 0;
		    transform.LookAt(_camera.transform.position - _vector);
		    transform.forward = transform.forward * -1;
        }
    }
}