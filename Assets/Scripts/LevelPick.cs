using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPick : MonoBehaviour
{
    public void PickeOne()
    {
        SceneManager.LoadScene("Level01");
    }
    public void PickeTwo()
    {
        SceneManager.LoadScene("Level02");
    }
    public void PickeThree()
    {
        SceneManager.LoadScene("Level03");
    }
}
