using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {

	private Transform _gate;
	private NavMeshAgent _navMeshAgent;

	private void Start () {

		_gate = GameObject.Find ("Castle").transform.Find ("Gate");
		_navMeshAgent = GetComponent <NavMeshAgent> ();

	}

	private void Update () {

		_navMeshAgent.SetDestination (_gate.position);

	}

	private void OnCollisionStay (Collision _collision) {

		if (_collision.gameObject.tag == "Gate") {

			float _timer = 0f;

			_timer += Time.deltaTime;

		}

	}

}
