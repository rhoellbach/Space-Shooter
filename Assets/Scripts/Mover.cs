using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	private float speed;

	void Start() 
	{
		speed = -3 * (Random.Range(1,3));

		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}


}
