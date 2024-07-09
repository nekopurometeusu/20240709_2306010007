using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }
    // Start is called before the first frame update

    //�Q�[���I��
    public void EndGame()
    {
        //�l�������X�R�A�ƃ��U���g��ʂ֑J��
        SceneData.score = ScoreScript.instance.GetCurrentScore();
        SceneManager.LoadScene("Result");
    }

    public void ReturnStart()
    {
        ResetGameData();
        SceneManager.LoadScene("Start");
    }

    private void ResetGameData()
    {
        SceneData.score = 0;
        SceneData.totalBlocks = 0;

        //�u���b�N��������
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");
        foreach (GameObject block in blocks)
        {
            Destroy(block);
        }

        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(-ScoreScript.instance.GetCurrentScore());
        }


    }

}
