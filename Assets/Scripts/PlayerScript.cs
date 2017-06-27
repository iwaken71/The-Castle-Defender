using UnityEngine;

public class PlayerScript : MonoBehaviour {

	private Transform _cameraTransform;
	private Vector3 _cameraForward;
	private Vector3 _cameraDirection;
	private Rigidbody _rigidbody;
	private GameObject _player;
	public GameObject _bowAndArrow;
	private Transform _bowAndArrowPoint;
	private float _timer = 0f;

	private void Start () {

		_cameraTransform = Camera.main.transform;
		_rigidbody = GetComponent <Rigidbody> ();
		_player = GameObject.Find ("Player");
		_bowAndArrowPoint = _player.transform.Find ("Bow & ArrowPoint");

		GameObject _bowAndArrowInstantiate = Instantiate (_bowAndArrow, _bowAndArrowPoint.position, _cameraTransform.rotation * Quaternion.Euler (0f, -90f, 0f)) as GameObject;
		_bowAndArrowInstantiate.transform.SetParent (_cameraTransform);

	}

	private void Update () {

		if (Input.GetMouseButton (1)) {

			_timer += Time.deltaTime;

		}

		if (Input.GetMouseButtonUp (1)) {

			if (_timer > 1f) {

				Transform _arrow = GameObject.Find ("Player").transform.Find ("Bow & Arrow(Clone)");
				Rigidbody _arrowRigidbody = _arrow.gameObject.GetComponent <Rigidbody> ();

				_arrowRigidbody.useGravity = true;
				_arrowRigidbody.AddForce (Camera.main.transform.forward * 500f);

				_timer = 0f;

			}

		}

	}

	private void FixedUpdate () {

		float _horizontal = Input.GetAxis ("Horizontal");
		float _vertical = Input.GetAxis ("Vertical");

		if (_cameraTransform != null) {

			_cameraForward = Vector3.Scale (_cameraTransform.forward, new Vector3 (1, 0, 1)).normalized;

			_cameraDirection = _vertical * _cameraForward + _horizontal * _cameraTransform.right.normalized;

		} else {

			_cameraDirection = _vertical * Vector3.forward + _horizontal * Vector3.right.normalized;

		}

		_rigidbody.velocity = _cameraDirection * 5f;

	}

}
