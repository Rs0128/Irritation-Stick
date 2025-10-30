using UnityEngine;

/// <summary>
/// ゴールに触れたらゴールシーンに遷移するクラス。
/// </summary>
public class Goal : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(PLAYER_TAG))
        {
            SceneController.LoadGoal();
        }
    }
}
