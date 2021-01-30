using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class TextChange : MonoBehaviour
{
    public void Change(float f)
    {
        f = f * 100;
        float rf = Mathf.Round(f);
        GetComponent<Text>().text = "Volume: " + rf.ToString() + "%";
    }

}
