using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour {
    public GameObject cube;
    public GameObject scoreText;
    private float count = 0;
    private float interval = 1.0f;
    private int score = 0;

    public void Update () {
        count += Time.deltaTime;
        if (count > interval)　 //適当な間隔で箱を配置
        {
            count = 0;
            GameObject instance = Instantiate (cube);
            instance.transform.position = new Vector3 (Random.value * 20 - 10, 10, 10);
        }
    }

    public void AddScore () {
        score++;
        scoreText.GetComponent<Text> ().text = score.ToString (); //内容をスコアに設定。

        if (score == 10) {
            SceneManager.LoadScene ("Clear"); //シーンの遷移
        }
    }
}