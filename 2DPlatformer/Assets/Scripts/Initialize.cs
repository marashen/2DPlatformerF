using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initialize : MonoBehaviour
{
   public void Start()
    {
        SceneManager.LoadScene(1);
    }
}
