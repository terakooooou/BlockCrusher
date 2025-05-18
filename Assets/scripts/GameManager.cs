using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameClearUI; // ← 追加

    private bool isGameCleared = false;

    void Update()
    {
        if (!isGameCleared && DestroyAllBlocks())
        {
            isGameCleared = true;
            Debug.Log("ゲームクリア");

            // ゲームクリアUI表示
            if (gameClearUI != null)
            {
                gameClearUI.SetActive(true);
            }

            // 全ボールを停止
            StopAllBalls();
        }
    }

    private bool DestroyAllBlocks()
    {
        block[] remainingBlocks = FindObjectsOfType<block>();
        return remainingBlocks.Length == 0;
    }

    private void StopAllBalls()
    {
        ball[] balls = FindObjectsOfType<ball>();
        foreach (ball b in balls)
        {
            b.StopBall();
        }
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
