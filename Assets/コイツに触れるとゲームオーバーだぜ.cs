using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class コイツに触れるとゲームオーバーだぜ : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("ゲームオーバー画面");
        }
    }
}
