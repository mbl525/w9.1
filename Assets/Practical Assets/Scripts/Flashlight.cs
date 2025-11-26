using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour 
{
	public Light target; 
	public KeyCode key;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		if (Input.GetKeyDown (key)) 
		{
			target.enabled = !target.enabled;
		}
	}
}
