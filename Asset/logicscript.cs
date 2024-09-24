using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text Textscore;
    public GameObject gameover;
    public bool alive = true;

    public void addscore(int scoreadded)
    {
        if (alive == true)
        {
            playerscore += scoreadded;
            Textscore.text = playerscore.ToString();
        }
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameoverscreen()
    {
        alive = false;
        gameover.SetActive(true);
    }
}
