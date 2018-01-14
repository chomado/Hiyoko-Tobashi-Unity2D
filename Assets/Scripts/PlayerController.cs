using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed = 8f;
    public float MovableRange = 5.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // プレイヤーを動かす処理
        this.transform.Translate(
            x: Input.GetAxisRaw(axisName: "Horizontal") * Speed * Time.deltaTime, 
            y: 0, 
            z: 0
        );
        // 移動範囲を制限する処理
        this.transform.position = new Vector2(
            x: Mathf.Clamp(value: this.transform.position.x, min: -MovableRange, max: MovableRange),
            y: this.transform.position.y // y 軸についてはとくに制限をかけない
        );
	}
}
