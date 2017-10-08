using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float Speed = 30;

	// Rotates the cube.
	void Update()
	{
		transform.Rotate( Vector3.up * Speed * Time.deltaTime );
	}
}
