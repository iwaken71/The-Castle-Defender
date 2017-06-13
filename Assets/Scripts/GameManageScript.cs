using UnityEngine;

public class GameManageScript : MonoBehaviour {

	public static GameManageScript _instance = null;

	private void Awake () {

		if (_instance == null) {

			_instance = this;

			DontDestroyOnLoad (this.gameObject);

		} else {

			Destroy (this.gameObject);

		}

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

	}

	private void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {

			Cursor.visible = true;

		}

	}

}
