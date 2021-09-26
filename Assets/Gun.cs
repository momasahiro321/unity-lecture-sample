using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject ball;

    private float angleX;
    private float angleY;
    private float speed = 45.0f;

    public void Update () {
        float deltaAngle = speed * Time.deltaTime; //前フレームからの経過時間から回転量を計算

        if (Input.GetKey (KeyCode.DownArrow)) {
            angleX += deltaAngle;
        } else if (Input.GetKey (KeyCode.UpArrow)) {
            angleX -= deltaAngle;
        }

        if (Input.GetKey (KeyCode.RightArrow)) {
            angleY += deltaAngle;
        } else if (Input.GetKey (KeyCode.LeftArrow)) {
            angleY -= deltaAngle;
        }

        if (Input.GetKeyDown (KeyCode.Space)) {
            GameObject ballInstance = Instantiate (ball);
            ballInstance.GetComponent<Ball> ().Fire (transform.position, transform.rotation); //インスタンスにアタッチされているBallのFire関数を呼び出す
        }

        transform.rotation = Quaternion.Euler (angleX, angleY, 0); //回転を設定
    }
}