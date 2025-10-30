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
    /// �J�E���g�_�E���\�� �� �v���C���[�J�n
    /// </summary>
    private IEnumerator CountdownRoutine()
    {
        int count = startCountdownSeconds;

        while (count > 0)
        {
            countdownText.text = count.ToString();
            yield return new WaitForSeconds(1);
            count--;
        }

        countdownText.text = GO_TEXT;
        yield return new WaitForSeconds(1);

        countdownText.enabled = false;

        player.StartMove();
    }
}
