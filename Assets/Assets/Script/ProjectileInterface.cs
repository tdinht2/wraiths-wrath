using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProjectile{
	void createProjectile(Vector3 position);
	void move();
	void onCollisionEnter();
}
