using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafallow : MonoBehaviour {


    public Transform Target;
	// Update is called once per frame
	void Update ()
    {

        this.transform.position = new Vector3(Target.position.x, this.transform.position.y, this.transform.position.z);

	}
}
