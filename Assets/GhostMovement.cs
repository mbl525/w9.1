using UnityEngine;
using UnityEngine.AI;

public class GhostMovement : MonoBehaviour
{
    enum GhostState {
        WANDERING,
        PLAYER_SEEN,
        PLAYER_CAUGHT,
        PLAYER_EAT
    };
    GhostState state = GhostState.WANDERING;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent> ();
        if (state == GhostState.WANDERING) {
            if (agent.remainingDistance <= 1.0f) {
            float x = Random.Range(-75.0f, 75.0f);
            float z = Random.Range(-75.0f, 75.0f);
            agent.destination = new Vector3(x, 0.0f, z);
            }
        } else if (state == GhostState.PLAYER_SEEN) {
            agent.destination = player.transform.position;
        } else if (state == GhostState.PLAYER_CAUGHT) {
            Debug.Log("hello?");
            //game over ui
        }
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player") {
            state = GhostState.PLAYER_SEEN;
            player = other.gameObject;
        }
    }

    void CollisionEnter(Collision other) {
        if (other.gameObject.name == "Player") {
            state = GhostState.PLAYER_SEEN;
            player = other.gameObject;
        }
    }
}
