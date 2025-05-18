using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameClearUI; // �� �ǉ�

    private bool isGameCleared = false;

    void Update()
    {
        if (!isGameCleared && DestroyAllBlocks())
        {
            isGameCleared = true;
            Debug.Log("�Q�[���N���A");

            // �Q�[���N���AUI�\��
            if (gameClearUI != null)
            {
                gameClearUI.SetActive(true);
            }

            // �S�{�[�����~
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
        Debug.Log("�Q�[���I�[�o�[");
        gameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
