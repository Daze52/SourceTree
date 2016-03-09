using UnityEngine;
using System.Collections;

public class ok : MonoBehaviour {
	int myInt = 6;

	int multiplybytwo (int number){
		int ret = number * 2;
		return ret;
	}

	// Use this for initialization
	void Start () {
		myInt = multiplybytwo (myInt);
		Debug.Log (myInt);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
