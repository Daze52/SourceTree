using UnityEngine; using System.Collections;
public class BoolScript : MonoBehaviour 
{
	bool isFlying = false;
	//A bool can be one of two values. 'true' or 'false' bool isFlying = false;

	// Use this for initialization 
	void Start () { 

	//Use '==' to test whether or not isFlying is false

	if(isFlying == false) 
	{

		Debug.Log("isFlying is now " + isFlying); 

		//get the return value from FlyingTest and set it to isFlying isFlying = FlyingTest(); Debug.Log("isFlying is now " + isFlying);

	} 
	else if(isFlying == true) 
	{

		Debug.Log("isFlying is already true");

	}
	}

}