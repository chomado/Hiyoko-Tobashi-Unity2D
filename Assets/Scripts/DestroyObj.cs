using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {

    public float deleteTime = 2.0f;

	// Use this for initialization
	void Start () {
        Destroy(obj: gameObject, t: deleteTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
