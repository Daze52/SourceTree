using UnityEngine;
using System.Collections;

public class DoWhileLoops : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{

		bool shouldcontinue = false;
	
		do
		{
			Debug.Log ("this is the dowhile script.");
		}while (shouldcontinue == true);
		
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}