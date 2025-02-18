using UnityEngine;
using System.Collections;

public class GeneratorEmpty : MonoBehaviour
{
	private int frame;
	private Spawner spawner = new Spawner();

	void Update()
	{
		frame += 1;
		if (frame >= GlobalVariables.GeneratorTime)
		{
			spawner.GeneratorFull(transform.position);
			Destroy(gameObject);
		}
	}
}
