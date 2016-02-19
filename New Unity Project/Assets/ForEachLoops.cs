using UnityEngine;
using System.Collections;

public class ForEachLoops : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] list = new string[3];

		list [0] = "First String";
		list [1] = "Second String";
		list [2] = "Third String";

		foreach (string item in list)
		{
			print (item);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
