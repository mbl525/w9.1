using UnityEngine;
using System.Collections;

public class GhostLaughter : MonoBehaviour 
{
	public float minInterval = 5.0f;
	public float maxInterval = 20.0f;
	public AudioSource laughterSource;

	private float nextLaugh;

	void Start () 
	{
		CalculateNextLaugh ();
	}
	
	void Update () 
	{
		if (Time.time >= nextLaugh) 
		{
			if(!laughterSource.isPlaying)
			{
				laughterSource.Play();
			}

			CalculateNextLaugh();
		}
	}

	private void CalculateNextLaugh()
	{
		nextLaugh = Time.time + Random.Range (minInterval, maxInterval);
	}
}
