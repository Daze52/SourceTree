using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	Rigidbody RB;
	public float enemyspeed = 50;
	Vector3 direction;
	GameObject reference;
	EnemyDamage damagereference;

	void Start()
	{
		RB = GetComponent<Rigidbody> ();

		reference = GameObject.FindGameObjectWithTag ("Player");

		damagereference = GetComponent<EnemyDamage> ();

		if (damagereference.enemytype == EnemyDamage.num.drink) 
		{
			direction = new Vector3 (0, Random.Range (0, 360), 0);
			
			transform.eulerAngles = direction;
		}

	}

	void Update()
	{
		RB.AddRelativeForce (transform.forward * enemyspeed);
	}
}
	/*
     * Additional Variables:
     * A private GameObject to hold a reference to the player
     * A private enemy damage variable that holds a reference to the enemy damage script on the enemy
     */
	
	/*
     * Additional Lines in the Start Function:
     *      Use FindGameObjectWithTag with the player's tag in order to get the reference to the player
     *      Use GetComponent to get the reference to your enemy damage script
     *      If (the type variable in the enemy damage script is equal to the first type of enemy)
     *          Put the line that sets a random direction into this If statement
     */
	
	/*
     * Additional Lines in the Update Function:
     *      If (the type variable in the enemy damage script is equal to the second type of enemy OR the type is equal to the third type of enemy)
     *          Use the LookAt function with the player's transform.
     */
	
	/* **************Explanation and Hints************ 
    * FindGameObjectWithTag - This will find a GameObject with a specific tag. In this case we are using it to get a reference to the player.
    *                         You can do this by typing out the following
    *
    *                         *nameOfPlayerVariable* = GameObject.FindGameObjectWithTag("EnterPlayerTagHere");
    *
    * Getting a reference to the enemy damage script - You can do this the same way as getting the rigidbody except you replace "rigidbody" for
    *                                                  the name of the script. For example:
    *                                                   
    *                                                  *enemyDamageVariableName* = GetComponent<*enemyDamageScriptName*>();
    *
    * Comparing the type of enemy - In order to figure out what type of enemy this is we need to use the enemy damage variable from above.
    *                               Then we use the dot operator to access the type variable in that script. After the double equals we need
    *                               to use the enemy damage variable once again to access the enum we are comparing the type to.
    *
    * LookAt - The LookAt function rotates this GameObject to face a target. In this case we want to rotate the enemy so that it is facing the player.
    *          We can do this by typing the following:
    *          
    *          transform.LookAt(*nameOfPlayerVariable*.transform);
    */

	
