using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

/// <summary>
/// �Q�[���J�n���̃J�E���g�_�E���������Ǘ�����N���X�B
/// �J�E���g�I����Ƀv���C���[�𓮂����n�߂�B
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("Countdown Settings")]
    [Tooltip("�J�E���g�_�E���J�n�b��")]
    public int startCountdownSeconds = 3;

    [Tooltip("�J�E���g�_�E���\��UI")]
    public TextMeshProUGUI countdownText;

    [Tooltip("����Ώۃv���C���[")]
    public PlayerController player;

    private const string GO_TEXT = "GO!";

    private void Start()
    {
        StartCoroutine(CountdownRoutine());
    }

    /// <summary>
    /// �J�E���g�_�E���\�� �� �uGO!�v �� �v���C���[�J�n
    /// </summary>
    private IEnumerator CountdownRoutine()
    {
        int count = startCountdownSeconds;

        while (count > 0)
        {
            countdownText.text = count.ToString();
            AudioManager.Instance.PlaySE(AudioManager.Instance.countdownSE);
            yield return new WaitForSeconds(1);
            count--;
        }

        // "GO!"��\������1�b�ԃL�[�v
        countdownText.text = GO_TEXT;
        AudioManager.Instance.PlaySE(AudioManager.Instance.countdownSE);

        yield return new WaitForSeconds(1);

        countdownText.enabled = false;

        // �v���C���[�J�n
        player.StartMove();
    }
}
