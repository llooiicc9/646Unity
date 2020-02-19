using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class Delay : MonoBehaviour
{

    void Start()
    {
        DOVirtual.DelayedCall(5, GoToNextScene);
    }

    
    void GoToNextScene()
    {
        SceneManager.LoadScene("Reward 1");
    }
}
