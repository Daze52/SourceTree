using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour 
{
	enum Direction {Up, Down, Left, Right};
	
	void Start () 
	{
		Direction myDirection;
		
		myDirection = Direction.Left;
		
		myDirection = reverse (myDirection);
	}
	
	Direction reverse (Direction dir)
	{
		if (dir == Direction.Left)
		{
			dir = Direction.Right;
		}
		else if (dir == Direction.Right)
		{
			dir = Direction.Left;
		}
		else if (dir == Direction.Up)
		{
			dir = Direction.Down;
		}
		else if (dir == Direction.Down)
		{
			dir = Direction.Up;
		}
		return dir;
	}
}
