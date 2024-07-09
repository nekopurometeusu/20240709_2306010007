using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultController : MonoBehaviour
{
    //�e�L�X�g����
    public GameObject scoreText;
    public GameObject resultText;
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "SCORE:" + SceneData.score;
        //GAMECLAER�@or GAMEOVER
        if (SceneData.totalBlocks == 0)
        {
            this.resultText.GetComponent<TextMeshProUGUI>().text = "GAME CLAER";

        }
        else
        {
            this.resultText.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
        }
    }

    //�X�^�[�g��ʂւ̑J��
    public void OnReturnBottonPressed()
    {
        GameController.instance.ReturnStart();
    }

}
