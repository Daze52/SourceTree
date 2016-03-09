using UnityEngine;
using System.Collections;

public class ScopeAndAccessMod1 : MonoBehaviour 
{
	public int Red = 1;

	public int Blue = 2;

	int Purple = 0;

	int mix (int color1, int color2)
	{
		int ret = color1 + color2;
		
		return ret;
	}
	void Start () 
	{
		Purple = mix (Red, Blue);

		print ("Purple is " + Purple);
	}
}