using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public block[] blocks;
    public GameObject gameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyAllBlocks()==true)
        {
            Debug.Log("ゲームクリア");
        }
    }

    private bool DestroyAllBlocks()
    {
        foreach(block b in blocks)
        {
            if (b != null) {
                return false; 
            }
        }
        return true;
    }
    public void GameOver()
    {
        Debug.Log("ゲームオーバー");
        gameOverUI.SetActive(true);

    }

    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
