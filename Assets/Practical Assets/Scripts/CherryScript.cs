using UnityEngine;
using System.Collections;

public class CherryScript : MonoBehaviour 
{
	public float spawnArea = 50.0f;	
	public float timeLimit = 30.0f;
	public float spinSpeed = 45.0f;

	private float spawned;
	private float spawnTime;

	void Start () 
	{
		Respawn ();
	}
	
	void Update () 
	{
		if (Time.time - spawned > spawnTime) 
		{
			Respawn();
		}

		transform.Rotate (0.0f, spinSpeed * Time.deltaTime, 0.0f);
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name != "Ghost") 
		{
			Respawn ();
		}
	}

	void OnCollisionStay(Collision other)
	{
		if (other.gameObject.name != "Ghost") 
		{
			Respawn ();
		}
	}

	private void Respawn()
	{
		float x = Random.Range (-spawnArea, spawnArea);
		float z = Random.Range (-spawnArea, spawnArea);

		spawned = Time.time;
		spawnTime = Random.Range (0.0f, timeLimit);
		
		transform.position = new Vector3 (x, transform.position.y, z);
	}
}
