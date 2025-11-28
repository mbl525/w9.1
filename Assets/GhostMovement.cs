using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GhostMovement : MonoBehaviour
{
   public enum GhostState {
       WANDERING,
       PLAYER_SEEN,
       PLAYER_CAUGHT,
       PLAYER_EATS_CHERRY,
       RETURN_HOME
   };
  
   GhostState state = GhostState.WANDERING;
   public GameObject player;
   Vector3 startPosition;

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      startPosition = transform.position;
   }


   // Update is called once per frame
   void Update()
   {
       bool cherryStatus = player.GetComponent<CherryCollision>().cherryMode;
       NavMeshAgent agent = GetComponent<NavMeshAgent>();
       if (state == GhostState.WANDERING) {
           if (agent.remainingDistance <= 1.0f) {
               float x = Random.Range(-75.0f,75.0f);
               float z = Random.Range(-75.0f,75.0f);
               agent.destination = new Vector3(x, 0.0f, z);
           }
       } else if (state == GhostState.PLAYER_SEEN) {
            agent.destination = player.transform.position;
            if (state == GhostState.PLAYER_SEEN && agent.remainingDistance <= 1.0f) {
               // two == is a conditionnal
                state = GhostState.PLAYER_CAUGHT;
            } else if (cherryStatus == true) {
                state = GhostState.RETURN_HOME;
            }
       
       } if (state == GhostState.PLAYER_CAUGHT) {
           //Restarts the game
           //Possible extension: Adding UI screen
           //W1.2 (Optional extension code)
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       } else if (state == GhostState.RETURN_HOME) {
            agent.destination = startPosition;
            StartCoroutine(Respawn());
       }
   }


   void OnTriggerEnter(Collider other) {
       if (other.gameObject.name == "Player") {
           state = GhostState.PLAYER_SEEN;
           player = other.gameObject;
       }
   }


   void OnCollisionEnter(Collision other) {
       if (other.gameObject.name == "Player") {
           state = GhostState.PLAYER_CAUGHT;
           player = other.gameObject;
       }
   }

   IEnumerator Respawn() {
        yield return new WaitForSeconds(5);
        state = GhostState.RETURN_HOME;
   }
}