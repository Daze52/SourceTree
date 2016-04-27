using UnityEngine;
using System.Collections;

public class DataTypes : MonoBehaviour 
{
	public class Colors
	{
		public int red;
		public int blue;
		public int green;
		
		public Colors(int r, int b, int g)
		{
		
			red = r;
			blue = b;
			green = g;
		}
	}
	
	public Colors myColor = new Colors(1, 2, 3);
}
