using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoretext;
    private int updatedscore;

    // Start is called before the first frame update
    void Start()
    {
        updatedscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void AddScore(int score)
    {
        updatedscore += score;
        scoretext.text = "Score: " + updatedscore;
    }
}
