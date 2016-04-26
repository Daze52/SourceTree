using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{

	public enum num{burger, fries, drink};
	public num enemytype;
	public int enemyhealth = 15;

	public void damage(int damageamount)
	{
		enemyhealth -= damageamount;

		if (enemyhealth <= 0) 
		{
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision hit)
	{

		if (hit.transform.tag == "killzone") 
		{
			Destroy (gameObject);

		} 
		else if (hit.transform.tag == "Bullet") 
		{
			switch (enemytype)
			{
				case num.burger:

				damage(5);

				break;

				case num.fries:
				
				damage(10);
				
				break;
				
				case num.drink:
				
				damage(15);
				
				break;
				
				default:
			
				print ("Unrecognized enemy type.");
			
				break;
			}
		}
	}
	
		/*
    * Additional Variables:
    * A public enum that will contain constants for three different types of enemys
    * A public variable with the type being the enum above. This will determine what type of enemy this one is.
    * A public int for the enemy's health
    */
		
		/*
    * A damage function, void return type, parameters: an int for damage amount
    *       Have the health "subtract equals" the parameter that was passed in.
    *       if(the health variable is less than 0)
    *           Destroy this enemy
    */
		
		/* **************Explanation and Hints************ 
    * Subtract equals - This will take a variable and subtract a certain amount from it. For example:
    *                         
    *                   *healthVariable* -= *damageAmount*
    *                         
    *                   So if the health variable equals 15 and damage amount equal five then after running this line of
    *                   code the health variable will now equal 10
    * Destroy this game object - When the enemy has lost all of it's health we want it to be destroyed. We can do this by typing the following:
    *                            
    *                            Destroy(gameObject);
    */
}