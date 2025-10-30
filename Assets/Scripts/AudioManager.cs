using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Œø‰Ê‰¹ˆê——")]
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
    /// Œø‰Ê‰¹‚ğ1‰ñÄ¶
    /// </summary>
    public void PlaySE(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
