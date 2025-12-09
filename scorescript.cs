using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scorescript : MonoBehaviour
{
    public GameObject gameoverscreen;
    public int playerscore = 0;
    public Text scoretext;
    [ContextMenu("increasescore")]
    public void addscore()
    {
        playerscore += 1;
        scoretext.text = playerscore.ToString();
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerscore = 0;
        scoretext.text = playerscore.ToString();
        Time.timeScale = 1;
        

    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
        Time.timeScale = 0;
    }



}

