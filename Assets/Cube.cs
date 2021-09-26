using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    public void Update () {
        if (transform.position.y < -100) {
            Destroy (gameObject);
        }
    }

    public void OnCollisionEnter (Collision collision) {
        GameObject.Find("Main Camera").GetComponent<Main>().AddScore(); //メインカメラを取得して、スコアを上げる
    }
}