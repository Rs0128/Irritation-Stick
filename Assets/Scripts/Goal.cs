using UnityEngine;

/// <summary>
/// �S�[���ɐG�ꂽ��S�[���V�[���ɑJ�ڂ���N���X�B
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
