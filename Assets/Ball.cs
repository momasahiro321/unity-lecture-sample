using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public void Fire (Vector3 position, Quaternion rotation) {
        Vector3 gunDirection = rotation * Vector3.forward; //砲台の方向
        transform.position = position + gunDirection * 4; //砲弾の初期位置
        Vector3 force = gunDirection * 15; //発射の力
        GetComponent<Rigidbody> ().AddForce (force, ForceMode.Impulse); //RightBodyを取得し、力を加える
    }

    public void Update () {
        if (transform.position.y < -100) {
            Destroy (gameObject); //ある程度下まで落ちたら自分自身を削除
        }
    }
}