using UnityEngine;

public class CameraScript : MonoBehaviour {

	private GameObject _player;
	private Quaternion _playerRotation;
	private Quaternion _cameraRotation;

	private void Start () {

		_player = GameObject.Find ("Player");
		_playerRotation = _player.transform.localRotation;
		_cameraRotation = this.transform.localRotation;

	}

	private void Update () {

		float _xRotation = Input.GetAxis ("Mouse X") * 3f;
		float _yRotation = Input.GetAxis ("Mouse Y") * 3f;

		_playerRotation *= Quaternion.Euler (0f, _xRotation, 0f);
		_cameraRotation *= Quaternion.Euler (-_yRotation, 0f, 0f);

		_player.transform.localRotation = Quaternion.Slerp (_player.transform.localRotation, _playerRotation, 5f * Time.deltaTime);
		this.transform.localRotation = Quaternion.Slerp (this.transform.localRotation, _cameraRotation, 5f * Time.deltaTime);

	}

}
