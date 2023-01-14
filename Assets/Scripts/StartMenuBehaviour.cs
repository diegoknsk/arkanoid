using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuBehaviour : MonoBehaviour
{
    public GameObject creditsPanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void PressPlay()
    {
        SceneManager.LoadScene("Scenes/MainGame");
    }

    public void PressCredits(bool show)
    {
        creditsPanel.SetActive(show);
    }
    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.anyKeyDown)
    //    {
    //        SceneManager.LoadScene("Scenes/MainGame", LoadSceneMode.Single);
    //    }
    //}


}
