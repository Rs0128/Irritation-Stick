using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

/// <summary>
/// ゲーム開始時のカウントダウン処理を管理するクラス。
/// カウント終了後にプレイヤーを動かし始める。
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("Countdown Settings")]
    [Tooltip("カウントダウン開始秒数")]
    public int startCountdownSeconds = 3;

    [Tooltip("カウントダウン表示UI")]
    public TextMeshProUGUI countdownText;

    [Tooltip("操作対象プレイヤー")]
    public PlayerController player;

    private const string GO_TEXT = "GO!";

    private void Start()
    {
        StartCoroutine(CountdownRoutine());
    }

    /// <summary>
    /// カウントダウン表示 → 「GO!」 → プレイヤー開始
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

        // "GO!"を表示して1秒間キープ
        countdownText.text = GO_TEXT;
        AudioManager.Instance.PlaySE(AudioManager.Instance.countdownSE);

        yield return new WaitForSeconds(1);

        countdownText.enabled = false;

        // プレイヤー開始
        player.StartMove();
    }
}
