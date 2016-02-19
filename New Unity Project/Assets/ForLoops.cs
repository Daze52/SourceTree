using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour 
{
	int numenemies = 3;

	// Use this for initialization
	void Start () {

		for (int i = 0; numenemies > i; i++) 
		{
			Debug.Log ("creating enemy number " + i);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
