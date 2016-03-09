using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
	float coffeetemperature = 85.0f;
	float coffeelimit = 55.0f;

	// Use this for initialization
	void Start () 
	{
		if (coffeetemperature > coffeelimit) 
		{
			print ("Coffee is too hot.");
		}
		else if (coffeetemperature < coffeelimit)
		{
			print ("Coffee is too cold.");
		}
		else
		{
			print ("Coffee is just right!");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
