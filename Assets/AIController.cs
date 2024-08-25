using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public Transform Player;

    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _agent.destination = Player.position;
    }
}
