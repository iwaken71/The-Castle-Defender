using UnityEngine;

public class PlayerScript : MonoBehaviour {

	private Transform _cameraTransform;
	private Vector3 _cameraForward;
	private Vector3 _cameraDirection;
	private Rigidbody _rigidbody;

	private void Start () {

		_cameraTransform = Camera.main.transform;
		_rigidbody = GetComponent <Rigidbody> ();

	}

	private void FixedUpdate () {

		float _horizontal = Input.GetAxis ("Horizontal");
		float _vertical = Input.GetAxis ("Vertical");

		if (_cameraTransform != null) {

			_cameraForward = Vector3.Scale (_cameraTransform.forward, new Vector3 (1, 0, 1)).normalized;

			_cameraDirection = _vertical * _cameraForward + _horizontal * _cameraTransform.right;

		} else {

			_cameraDirection = _vertical * Vector3.forward + _horizontal * Vector3.right;

		}

		_rigidbody.velocity = _cameraDirection * 5f;

	}

}
