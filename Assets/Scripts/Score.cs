using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public string playerScore;
    private string path = Directory.GetCurrentDirectory() + "/SaveData.txt";
    private string un;
    private void Start()
    {
        un = File.ReadAllText(path);
    }
    // Update is called once per frame
    void Update()
    {
        playerScore = player.position.z.ToString("0");
        scoreText.text = un + "\n" + playerScore;
    }
}
