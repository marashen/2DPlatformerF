using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CoinCollect : MonoBehaviour
{
    public int p_Score;
    public int coinWin = 0;
    public static CoinCollect instance;
    public ParticleSystem collisonParticleSystem;
    public bool once = true;

    private void Awake()
    {
        instance = this;
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (coinWin == 0)
        {
            TimeControl.instance.BeginTimer();
        }
        if (collider2D.gameObject.CompareTag("Coin"))
        {
            var em = collisonParticleSystem.emission;
            em.enabled = true;
            once = false;
            collisonParticleSystem.Play();

            Destroy(collider2D.gameObject);
            p_Score += 100;
            coinWin++;
            if (coinWin >= 15)
            {
                GameObject.FindGameObjectWithTag("Music").GetComponent<MusicMenus>().PlayMusic();
                SceneManager.LoadScene(3);
            }
        }
     
    }
}
