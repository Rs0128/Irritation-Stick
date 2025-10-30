using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("���ʉ��ꗗ")]
    public AudioClip buttonSE;
    public AudioClip moveSE;
    public AudioClip countdownSE;
    public AudioClip wallHitSE;

    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// ���ʉ���1��Đ�
    /// </summary>
    public void PlaySE(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
