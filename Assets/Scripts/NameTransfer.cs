using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public GameObject inputField;
    private string un;
    private string path = Directory.GetCurrentDirectory() + "/SaveData.txt";
    public void StoreName()
    {
        un = inputField.GetComponent<Text>().text;
        if(un == "Enter Your Name")
        {
            un = "";
        }
        File.WriteAllText(path, un);
    }

    public void ClearName()
    {
        File.WriteAllText(path, "");
    }
}
