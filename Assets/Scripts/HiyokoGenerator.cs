using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour {

    public GameObject hiyokoObj; // ひよこ玉のプレハブ
    public float interval = 3.0f;

	// Use this for initialization
	void Start () {
        // 一定間隔で生成する
        InvokeRepeating(methodName: "SpawnObj", time: 0.1f, repeatRate: this.interval);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // ひよこ玉を生成する
    void SpawnObj()
    {
        Instantiate(original: this.hiyokoObj, position: transform.position, rotation: transform.rotation);
    }
}
