using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (GameController.instance == null)
        {
            GameController.instance = FindAnyObjectByType<GameController>();
        }
        if (GameController.instance != null)
        {

            int blocks = SceneData.totalBlocks;
            GameController.instance.EndGame(blocks);
            Destroy(collision.gameObject);

        }
        else
        {
            Debug.Log("ゲームマネージャーがインスタンス化されていません");
        }
    }
}
