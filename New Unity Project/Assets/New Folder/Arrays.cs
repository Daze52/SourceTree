using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	public int[] the = {5, 4, 3, 2, 1};
	
	// Use this for initialization
	void Start () {

	for(int qw = 0; qw < the.Length; qw++)
	{
		Debug.Log ("the value in element number " +qw+ " is " +the[qw]);
	}
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
