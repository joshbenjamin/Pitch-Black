using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject cube;

    // Update is called once per frame
	void Update () {
        this.transform.position = cube.transform.position;
	}
}
