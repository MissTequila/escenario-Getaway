using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
   public void NewGamebtn (string newgamegetaway)
    {
        SceneManager.LoadScene(newgamegetaway);
    }

    public void ExitGamebtn()
    {
        Application.Quit();
    }

}
