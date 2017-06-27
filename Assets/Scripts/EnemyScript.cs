using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {

	private Transform _gatePoint;
	private GameObject[] _gate;
	private NavMeshAgent _navMeshAgent;
	float _timer = 0f;

	private void Start () {

		_gatePoint = GameObject.Find ("Castle").transform.Find ("Gate");
		_gate = GameObject.FindGameObjectsWithTag ("Gate");
		_navMeshAgent = GetComponent <NavMeshAgent> ();

	}

	private void Update () {

		_navMeshAgent.SetDestination (_gatePoint.position);

	}

	private void OnTriggerStay (Collider _collider) {

		if (_collider.gameObject.tag == "GateChecker") {

			_timer += Time.deltaTime;

			if (_timer > 5f) {



			}

		}

	}

}
