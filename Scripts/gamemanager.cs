using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public Text coins;
    public int coinCount = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins Left: " + coinCount.ToString();
    }

    public void subtractCoin()
    {
        coinCount--;
        if (coinCount == 0)
        {
            resetScene();
        }
    }

    void resetScene()
    {
        SceneManager.LoadScene("DemoScene_Dungeon");
    }
}
