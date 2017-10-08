using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float Speed = 30;

	void Update()
	{
		transform.Rotate( Vector3.up * Speed * Time.deltaTime );
	}
}
