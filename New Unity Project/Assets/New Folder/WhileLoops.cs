using UnityEngine;
using System.Collections;

public class WhileLoops : MonoBehaviour 
{
	int cupsinthesink = 4;

	// Use this for initialization
	void Start () 
	{
		while (cupsinthesink > 0) 
		{
			Debug.Log ("I have shattered a cup on the floor.");

			cupsinthesink --;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
