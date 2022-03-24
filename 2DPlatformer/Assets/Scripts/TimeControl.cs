using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeControl : MonoBehaviour
{
    public int timeLeft = 180;
    public Text timeCard;
    public Text scoreCard;
    public static TimeControl instance;
    int checker = 0;

    private void Awake()
    {
        instance = this;
    }

    public void BeginTimer()
    {
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (timeLeft > 0)
        {
            timeLeft--;
            timeCard.text = timeLeft + " SECONDS LEFT!";
            scoreCard.text = CoinCollect.instance.p_Score + (timeLeft * 3) + " Points";

            yield return new WaitForSeconds(1);

            if (!CoinCollect.instance.once && checker != CoinCollect.instance.coinWin)
            {
                var em = CoinCollect.instance.collisonParticleSystem.emission;
                em.enabled = false;
                checker = CoinCollect.instance.coinWin;
            }
        }
            SceneManager.LoadScene(3);
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicMenus>().PlayMusic();
    }
}