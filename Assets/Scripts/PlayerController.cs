using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed = 8f;
    public float MovableRange = 5.5f;
    public float Power = 1000f;
    public GameObject CannonBall;
    public Transform SpawnPoint;

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

        // スペースキーが押された時
        if (Input.GetKeyDown(key: KeyCode.Space))
        {
            Shoot();
        }
	}

    private void Shoot()
    {
        // CannonBall 変数に設定されたプレハブから、インタンス "newBullet" を生成
        GameObject newBullet = Instantiate(
            original: this.CannonBall,
            position: this.SpawnPoint.position, // 生成する位置は、SpawnPoint 変数に設定されたオブジェクトの位置情報
            rotation: Quaternion.identity // 角度を (0, 0, 0)にしてる
        ) as GameObject;

        // インスタンスを移動させる
        newBullet.GetComponent<Rigidbody2D>()
                 .AddForce(force: Vector3.up * this.Power);
    }
}
